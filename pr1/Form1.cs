using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
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
		private TeacherForm teacherForm = new TeacherForm();
		private StudentForm studentForm = new StudentForm();
		private string file;
		SoapFormatter formatter = new SoapFormatter();
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
			teacherForm.createteacherEvent += UpdateForm;
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
			//this.treeView1.Nodes.Clear();
			var alreadyAddedTeachers = new List<Teacher>();

			for (int teacherIndex = treeView1.Nodes.Count - 1; teacherIndex >= 0; teacherIndex--)
			{
				var teacherNode = treeView1.Nodes[teacherIndex];
				var currentTeacher = (Teacher)teacherNode.Tag;
				if (TeacherList.Teachers.Contains(currentTeacher))
				{
					alreadyAddedTeachers.Add(currentTeacher);
					SetTreeNodeFilterColor(teacherNode, city);
					var alreadyAddedStudents = new List<Student>();
					for (int i = teacherNode.Nodes.Count - 1; i >= 0; i--)
					{
						var studentNode = teacherNode.Nodes[i];
						var currentStudent = (Student)studentNode.Tag;
						if (!currentTeacher.Students.Contains(currentStudent))
						{
							teacherNode.Nodes.Remove(studentNode);
						}
						else
						{
							alreadyAddedStudents.Add(currentStudent);
							SetTreeNodeFilterColor(studentNode, city);
						}
					}
					foreach (Student student in currentTeacher.Students)
					{
						if (!alreadyAddedStudents.Contains(student))
						{
							var studentNode = new TreeNode(student.Surname);
							studentNode.Tag = student;
							SetTreeNodeFilterColor(studentNode, city);
							teacherNode.Nodes.Add(studentNode);
						}
					}
				}
				else
				{
					treeView1.Nodes.Remove(teacherNode);
				}
			}

			foreach (var teacher in TeacherList.Teachers)
			{
				if (!alreadyAddedTeachers.Contains(teacher))
				{
					var teacherNode = new TreeNode(teacher.Surname);
					teacherNode.Tag = teacher;
					SetTreeNodeFilterColor(teacherNode, city);
					for (int j = 0; j < teacher.Students.Count(); j++)
					{
						var studentNode = new TreeNode(teacher.Students[j].Surname);
						studentNode.Tag = teacher.Students[j];
						SetTreeNodeFilterColor(studentNode, city);
						teacherNode.Nodes.Add(studentNode);
					}
					treeView1.Nodes.Add(teacherNode);
					
				}
			}
			ShowSelected_Click();
		}

		private void SetTreeNodeFilterColor(TreeNode node, string city)
		{
			var color = Color.Black;
			if (!String.IsNullOrEmpty(city)
				&& (node.Tag as Human)?.HumanAddress.City != city)
			{
				color = Color.Gray;
			}
			node.ForeColor = color;
		}

		private bool TeacherInTreeView(TreeNodeCollection nodes, TreeNode treeNode)
		{
			bool teacherInTreeView = false;
			foreach(TreeNode node in nodes)
			{
				if (node.Tag == treeNode.Tag)
				{
					teacherInTreeView = true;
				}
			}
			return (teacherInTreeView);
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
		private void ShowSelected_Click()
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
			ShowFoto(null);
		}
		private void StudentToolStripMenuItem_Click(object sender, EventArgs e)
		{
			studentForm.TeacherList = TeacherList;
			studentForm.Student = null;
			studentForm.Show();
		}

		private void TeacherToolStripMenuItem_Click(object sender, EventArgs e)
		{
			teacherForm.TeacherList = TeacherList;
			teacherForm.Teacher = null;
			teacherForm.Show();
		}
		void UpdateForm()
		{
			InitializeComboBox();
			InitializeTree(this.CitycomboBox.Text);
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
			char[] separator = { '.' };
			string[] curentFile = file.Split(separator);
			if (curentFile[1] == "json")
			{
				using (StreamWriter fileStream = new StreamWriter("TeacherList.json"))
				{
					string jsonTeachers = JsonConvert.SerializeObject(TeacherList);
					fileStream.Write(jsonTeachers);
				}
			}else if(curentFile[1] == "soap")
			{
				using (FileStream fs = new FileStream("TeacherList.soap", FileMode.OpenOrCreate))
				{
					formatter.Serialize(fs, TeacherList);
				}
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
						teacherForm.Teacher = teacher;
						teacherForm.Show();
					}
					else if(item.Tag is Student)
					{
						var student = (Student)item.Tag;
						studentForm.TeacherList = TeacherList;
						studentForm.Student = student;
						studentForm.Show();
					}
				}
			}
		}
		private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
		{
			ShowSelected_Click();
		}

		private void jSONLoadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (StreamReader fileStream = new StreamReader("TeacherList.json"))
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
				teacherForm.TeacherList = TeacherList;
				InitializeComboBox();
				file = "TeacherList.json";
			}
		}
		private void soapLoadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (FileStream fs = new FileStream("TeacherList.soap", FileMode.OpenOrCreate))
			{
				var newTeacherList = (TeacherList)formatter.Deserialize(fs);
				TeacherList = newTeacherList;
			}
			file = "TeacherList.dat";
		}
		private void soapSaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (FileStream fs = new FileStream("TeacherList.soap", FileMode.OpenOrCreate))
			{
				formatter.Serialize(fs, TeacherList);
			}
		}
		private void jSONSaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (StreamWriter fileStream = new StreamWriter("TeacherList.json"))
			{
				string jsonTeachers = JsonConvert.SerializeObject(TeacherList);
				fileStream.Write(jsonTeachers);
			}
		}
	}
}