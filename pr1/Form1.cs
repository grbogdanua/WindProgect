using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr1
{
	public partial class Form1 : Form
	{
		public TeacherList TeacherList { get; private set; } = new TeacherList();
		private AddStudent addStudent = new AddStudent();
		private AddTeacher addTeacher = new AddTeacher();
		private DataTable teacherTable = new DataTable();
		private DataTable studentTable = new DataTable();
		//public static DirectoryInfo di;
		public Form1()
		{
			//di = Directory.CreateDirectory("Files\\Image");
			InitializeTeacherTable();
			InitializeStudentTable();
			//InitializeList();
			//CreateList();
			InitializeComponent();
			//initialeDataTanle();
			InitializeTree(null);
			InitializeComboBox();
			addStudent.createstudentEvent += ConectStudentToTeacher;
			addTeacher.createteacherEvent += OnAddTeacher;
		}
		private void InitializeTeacherTable()
		{
			teacherTable.Columns.Add("Id");
			teacherTable.Columns.Add("Surname");
			teacherTable.Columns.Add("Name");
			teacherTable.Columns.Add("Age");
			teacherTable.Columns.Add("Count Students");
			teacherTable.Columns.Add("City");
			teacherTable.Columns.Add("Strit");
			teacherTable.Columns.Add("House Number");
			teacherTable.Columns.Add("");
		}
		private void InitializeStudentTable()
		{
			studentTable.Columns.Add("Id");
			studentTable.Columns.Add("Surname");
			studentTable.Columns.Add("Name");
			studentTable.Columns.Add("Age");
			studentTable.Columns.Add("Mark");
			studentTable.Columns.Add("City");
			studentTable.Columns.Add("Strit");
			studentTable.Columns.Add("House Number");
			studentTable.Columns.Add("");
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}
		/*private void InitializeList()
		{
			Teacher teacher = new Teacher("Arison", "Dad", 30, new Address("Ukraine", "Kherson", "Kahovka", "Armanska", 156));
			teacher.AddStudent(new Student("David", "Forida", 19, new Address("Ukraine", "Kherson", "Nova Odesa", "Kolomia", 204), new Mark()));
			teacher.AddStudent(new Student("Frdor", "Hotica", 12, new Address("Ukraine", "Kherson", "Nova Odesa", "Kolomia", 205), new Mark()));
			TeacherList.AddTeacher(teacher);
			teacher = new Teacher("Arison", "Yaoi", 30, new Address("Ukraine", "Kherson", "Kolomia", "Armanska", 156));
			teacher.AddStudent(new Student("David", "Forida", 19, new Address("Ukraine", "Kherson", "Nova Odesa", "Kolomia", 204), new Mark()));
			teacher.AddStudent(new Student("Frdor", "Hotica", 12, new Address("Ukraine", "Kherson", "Nova Odesa", "Kahovka", 205), new Mark()));
			TeacherList.AddTeacher(teacher);
		}
		private void initialeDataTanle()
		{
			DataTable table = new DataTable();
			table.Columns.Add("id");
			table.Columns.Add("name");
			table.Columns.Add("surname");
			table.Columns.Add("age");
			table.Columns.Add("strit");
			table.Columns.Add("house");
			for (int i=0;i<list.Count(); i++)
			{
				table.Rows.Add(i + 1, list[i].name, list[i].surname, list[i].age,list[i].adress.strit,list[i].adress.house);
				this.chart1.Series["Age"].Points.AddXY(list[i].name, list[i].age);
			}
			this.dataGridView1.DataSource = table;
		}
		public void CreateList()
		{
			list.Add(new Human("ava", "dad", 10,"fyf",6));
			list.Add(new Human("aga", "gad", 15,"duf",7));
			list.Add(new Human("kgf", "dadh", 19,"fuf",9));
		}*/
		private void ListCites(out List<string> cites)
		{
			cites = new List<string> { };
			for(int i = 0; i < TeacherList.Teachers.Count(); i++)
			{
				AddNotSimilar(cites, TeacherList.Teachers[i].HumanAddress.City);
				for(int j = 0; j < TeacherList.Teachers[i].Students.Count(); j++)
				{
					AddNotSimilar(cites, TeacherList.Teachers[i].Students[j].HumanAddress.City);
				}
			}
		}
		private void AddNotSimilar(List<string> cites,string city)
		{
			if (cites.Count > 0)
			{
				bool similar = false;
				for(int i = 0; i < cites.Count(); i++)
				{
					if (cites[i] == city)
					{
						similar = true;
						break;
					}
				}
				if (similar == false)
				{
					cites.Add(city);
				}
				
			}
			else
			{
				cites.Add(city);
			}
		}
		/*public void InitializeTree()
		{
			this.treeView1.Nodes.Clear();
			TreeNode root = new TreeNode();
			root.Name = "Don";
			root.Text = "Teachers";
			this.treeView1.Nodes.Add(root);
			for(int i = 0; i < teacherList.Teachers.Count(); i++)
			{
				treeView1.Nodes[0].Nodes.Add(teacherList.Teachers[i].Surname);
				for(int j = 0; j < teacherList.Teachers[i].Students.Count(); j++)
				{
					treeView1.Nodes[0].Nodes[i].Nodes.Add(teacherList.Teachers[i].Students[j].Surname);
				}
			}
		}*/
		public void InitializeTree(string city)
		{
			this.treeView1.Nodes.Clear();
			for (int i = 0; i < TeacherList.Teachers.Count(); i++)
			{
				if (String.IsNullOrEmpty(city) || TeacherList.Teachers[i].HumanAddress.City == city)
				{
					var teacherNode = new TreeNode(TeacherList.Teachers[i].Surname);
					teacherNode.Tag = TeacherList.Teachers[i];
					for (int j = 0; j < TeacherList.Teachers[i].Students.Count(); j++)
					{
						if (String.IsNullOrEmpty(city) || TeacherList.Teachers[i].Students[j].HumanAddress.City == city)
						{
							var studentNode = new TreeNode(TeacherList.Teachers[i].Students[j].Surname);
							studentNode.Tag = TeacherList.Teachers[i].Students[j];
							teacherNode.Nodes.Add(studentNode);
						}
					}
					treeView1.Nodes.Add(teacherNode);
				}else if (!String.IsNullOrEmpty(city))
				{
					for (int j = 0; j < TeacherList.Teachers[i].Students.Count(); j++)
					{
						if (String.IsNullOrEmpty(city) || TeacherList.Teachers[i].Students[j].HumanAddress.City == city)
						{
							var studentNode = new TreeNode(TeacherList.Teachers[i].Students[j].Surname);
							studentNode.Tag = TeacherList.Teachers[i].Students[j];
							treeView1.Nodes.Add(studentNode);
						}
					}
				}
			}
		}
		public void InitializeComboBox()
		{
			List<string> cites = new List<string> { };
			ListCites(out cites);
			this.CitycomboBox.Items.Clear();
			for(int i = 0; i < cites.Count(); i++)
			{
				this.CitycomboBox.Items.Add(cites[i]);
			}
			this.CitycomboBox.Items.Add("All");
		}
		private void AddToTable(TreeNode activeNode)
		{
			if (activeNode.Tag is Teacher)
			{
				var teacher = (Teacher)activeNode.Tag;
				teacherTable.Rows.Add(teacherTable.Rows.Count + 1,
					teacher.Surname,
					teacher.Name,
					teacher.Age,
					teacher.Students.Count,
					teacher.HumanAddress.City,
					teacher.HumanAddress.Street,
					teacher.HumanAddress.Housenumber,teacher);
			}
			else if (activeNode.Tag is Student)
			{
				var student = (Student)activeNode.Tag;
				studentTable.Rows.Add(studentTable.Rows.Count + 1,
					student.Surname,
					student.Name,
					student.Age,
					student.Grade.AverageMark,
					student.HumanAddress.City,
					student.HumanAddress.Street,
					student.HumanAddress.Housenumber,student);
			}
		}
		private void ShowSelected_Click(object sender, EventArgs e)
		{
			teacherTable.Rows.Clear();
			studentTable.Rows.Clear();
			for (int i = 0; i < treeView1.Nodes.Count; i++)
			{
				var curentNode = treeView1.Nodes[i];
				if (curentNode.Checked == true)
				{
					AddToTable(curentNode);
				}
				if (curentNode.Nodes.Count > 0)
				{
					for(int j=0;j< curentNode.Nodes.Count; j++)
					{
						if (curentNode.Nodes[j].Checked == true)
						{
							AddToTable(curentNode.Nodes[j]);
						}
					}
				}
			}
			this.TeacherdataGridView.DataSource = teacherTable;
			this.TeacherdataGridView.Columns[0].Width = 20;
			this.TeacherdataGridView.Columns[1].Width = 50;
			this.TeacherdataGridView.Columns[2].Width = 50;
			this.TeacherdataGridView.Columns[3].Width = 50;
			this.TeacherdataGridView.Columns[4].Width = 60;
			this.TeacherdataGridView.Columns[5].Width = 70;
			this.TeacherdataGridView.Columns[6].Width = 60;
			this.TeacherdataGridView.Columns[7].Width = 50;
			this.TeacherdataGridView.Columns[8].Visible = false;
			this.StudentdataGridView.DataSource = studentTable;
			this.StudentdataGridView.Columns[0].Width = 20;
			this.StudentdataGridView.Columns[1].Width = 50;
			this.StudentdataGridView.Columns[2].Width = 50;
			this.StudentdataGridView.Columns[3].Width = 50;
			this.StudentdataGridView.Columns[4].Width = 60;
			this.StudentdataGridView.Columns[5].Width = 70;
			this.StudentdataGridView.Columns[6].Width = 60;
			this.StudentdataGridView.Columns[7].Width = 50;
			this.StudentdataGridView.Columns[8].Visible = false;
		}
		private void StudentToolStripMenuItem_Click(object sender, EventArgs e)
		{
			addStudent.TeacherList = TeacherList;
			addStudent.Show();
		}

		private void TeacherToolStripMenuItem_Click(object sender, EventArgs e)
		{
			addTeacher.Show();
		}
		void ConectStudentToTeacher(Student student, Teacher teacher)
		{
			for(int i=0; i<TeacherList.Teachers.Count(); i++)
			{
				if(TeacherList.Teachers[i] == teacher)
				{
					TeacherList.Teachers[i].Students.Add(student);
					InitializeTree(null);
					InitializeComboBox();
					break;
				}
			}
		}
		void OnAddTeacher(Teacher teacher)
		{
			TeacherList.Teachers.Add(teacher);
			InitializeTree(null);
			InitializeComboBox();
		}

		private void CitycomboBox_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			string selectedCity = this.CitycomboBox.SelectedItem.ToString();
			if (InThisCitySomebodyLives(selectedCity))
			{
				InitializeTree(selectedCity);
			}
			else
			{
				InitializeTree(null);
			}
		}
		private bool InThisCitySomebodyLives(string city)
		{
			ListCites(out List<string> Cites);
			bool result = false;
			for(int i = 0; i < Cites.Count(); i++)
			{
				if (Cites[i] == city)
				{
					result = true;
					break;
				}
			}
			return (result);
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{

			using (StreamWriter fileStream = new StreamWriter("TeacherList.json"))
			{
				string jsonTeachers = JsonConvert.SerializeObject(TeacherList);
				fileStream.Write(jsonTeachers);
			}
		}

		private void loadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using(StreamReader fileStream = new StreamReader("TeacherList.json"))
			{
				string jsonTeachers = fileStream.ReadToEnd();
				try
				{
					var teachersFromFile = JsonConvert.DeserializeObject<TeacherList>(jsonTeachers);
					this.TeacherList = teachersFromFile;
					InitializeTree(this.CitycomboBox.SelectedItem?.ToString());
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				InitializeComboBox();
			}
		}

		private void TeacherdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			var teacher = (Teacher)this.TeacherdataGridView.Rows[e.RowIndex].Cells[8].Value;
			ShowFoto(teacher.ImageAddress);
		}

		private void StudentdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			var student = (Student)this.StudentdataGridView.Rows[e.RowIndex].Cells[8].Value;
			ShowFoto(student.ImageAddress);
		}

		private void TeacherdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void StudentdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void ShowFoto(string addressFoto)
		{
			if (addressFoto != String.Empty)
			{
				this.pictureBox1.Image = Image.FromFile(addressFoto);
			}
			else
			{
				this.pictureBox1.Image = this.pictureBox1.ErrorImage;
			}
		}
	}
}
