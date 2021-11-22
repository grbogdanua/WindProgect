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
		private TeacherForm addTeacher = new TeacherForm();
		private StudentForm studentForm = new StudentForm();
		//public static DirectoryInfo di;
		public Form1()
		{
			//di = Directory.CreateDirectory("Files\\Image");
			//InitializeList();
			//CreateList();
			InitializeComponent();
			//initialeDataTanle();
			InitializeTree(null);
			InitializeComboBox();
			studentForm.createstudentEvent += UpdateForm;
			addTeacher.createteacherEvent += UpdateForm;
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
				var teacherRow = new ListViewItem(new[] {(this.teacherListView.Items.Count+1).ToString(),
					teacher.Surname,
					teacher.Name,
					teacher.Age.ToString(),
					teacher.Students.Count.ToString(),
					teacher.HumanAddress.City,
					teacher.HumanAddress.Street,
					teacher.HumanAddress.Housenumber.ToString()});
				teacherRow.Tag = teacher;
				this.teacherListView.Items.Add(teacherRow);
			}
			else if (activeNode.Tag is Student)
			{
				var student = (Student)activeNode.Tag;
				var studentRow = new ListViewItem(new[] { (studentListView.Items.Count+1).ToString(),
					student.Surname,
					student.Name,
					student.Age.ToString(),
					student.Grade.AverageMark.ToString(),
					student.HumanAddress.City,
					student.HumanAddress.Street,
					student.HumanAddress.Housenumber.ToString()});
				studentRow.Tag = student;
				this.studentListView.Items.Add(studentRow);
			}
		}
		private void ShowSelected_Click(object sender, EventArgs e)
		{
			this.studentListView.Items.Clear();
			this.teacherListView.Items.Clear();
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
		}
		private void StudentToolStripMenuItem_Click(object sender, EventArgs e)
		{
			studentForm.TeacherList = TeacherList;
			studentForm.Student = null;
			studentForm.Show();
		}

		private void TeacherToolStripMenuItem_Click(object sender, EventArgs e)
		{
			addTeacher.Show();
		}
		void UpdateForm()
		{
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

		private void ShowFoto(string addressFoto)
		{
			if (addressFoto != null)
			{
				this.pictureBox1.Image = Image.FromFile(addressFoto);
			}
			else
			{
				this.pictureBox1.Image = Image.FromFile("Files\\Image\\anonym.jpg");
			}
		}
		private void ListView_MouseClick(object sender, MouseEventArgs e)
		{
			var source = sender as ListView;
			foreach (ListViewItem item in source.Items)
			{
				if (item.Selected)
				{
					var human = (Human)item.Tag;
					ShowFoto(human.ImageAddress);
				}
			}
		}
		private void ListView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			var source = sender as ListView;
			foreach (ListViewItem item in source.Items)
			{
				if (item.Selected)
				{
					if (item.Tag is Teacher)
					{
						var teacher = (Teacher)item.Tag;
					}else if(item.Tag is Student)
					{
						var student = (Student)item.Tag;
						studentForm.TeacherList = TeacherList;
						studentForm.Student = student;
						studentForm.Show();
					}
				}
			}
		}
	}
}