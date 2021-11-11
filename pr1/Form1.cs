using System;
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
		public TeacherList teacherList = new TeacherList();
		private AddStudent addStudent = new AddStudent();
		private AddTeacher addTeacher = new AddTeacher();
		public Form1()
		{
			addStudent.Owner = this;
			InitiateList();
			//CreateList();
			InitializeComponent();
			//initialeDataTanle();
			initealeTree();
			initealeComboBox();
			addStudent.createstudentEvent += ConectStudentToTeacher;
			addTeacher.createteacherEvent += AddTeacher;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		private void InitiateList()
		{
			Teacher teacher = new Teacher("Arison", "Dad", 30, new Address("Ucraine", "Kherson", "Kahovka", "Armanska", 156));
			teacher.AddStudent(new Student("David", "Forida", 19, new Address("Ucraine", "Kherson", "Nova Odesa", "Kolomia", 204), new Mark()));
			teacher.AddStudent(new Student("Frdor", "Hotica", 12, new Address("Ucraine", "Kherson", "Nova Odesa", "Kolomia", 205), new Mark()));
			teacherList.AddTeacher(teacher);
			teacher = new Teacher("Arison", "Yaoi", 30, new Address("Ucraine", "Kherson", "Kolomia", "Armanska", 156));
			teacher.AddStudent(new Student("David", "Forida", 19, new Address("Ucraine", "Kherson", "Nova Odesa", "Kolomia", 204), new Mark()));
			teacher.AddStudent(new Student("Frdor", "Hotica", 12, new Address("Ucraine", "Kherson", "Nova Odesa", "Kahovka", 205), new Mark()));
			teacherList.AddTeacher(teacher);
		}
		/*private void initialeDataTanle()
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
			for(int i = 0; i < teacherList.Teachers.Count(); i++)
			{
				cites = AddNotSimilar(cites, teacherList.Teachers[i].HumanAddress.City);
				for(int j = 0; j < teacherList.Teachers[i].Students.Count(); j++)
				{
					cites = AddNotSimilar(cites, teacherList.Teachers[i].Students[j].HumanAddress.City);
				}
			}
		}
		private List<string> AddNotSimilar(List<string>cites,string city)
		{
			if (cites.Count > 0)
			{
				bool Similar = false;
				for(int i = 0; i < cites.Count(); i++)
				{
					if (cites[i] == city)
					{
						Similar = true;
						break;
					}
				}
				if (Similar == false)
				{
					cites.Add(city);
					return (cites);
				}
				else
				{
					return (cites);
				}
			}
			else
			{
				cites.Add(city);
				return (cites);
			}
		}
		public void initealeTree()
		{
			this.treeView1.Nodes.Clear();
			TreeNode rude = new TreeNode();
			rude.Name = "Don";
			rude.Text = "Teachers";
			this.treeView1.Nodes.Add(rude);
			for(int i = 0; i < teacherList.Teachers.Count(); i++)
			{
				treeView1.Nodes[0].Nodes.Add(teacherList.Teachers[i].Surname);
				for(int j = 0; j < teacherList.Teachers[i].Students.Count(); j++)
				{
					treeView1.Nodes[0].Nodes[i].Nodes.Add(teacherList.Teachers[i].Students[j].Surname);
				}
			}
		}
		public void initealeTree(string City)
		{
			this.treeView1.Nodes.Clear();
			TreeNode rude = new TreeNode();
			rude.Name = "Don";
			rude.Text = "Teachers";
			this.treeView1.Nodes.Add(rude);
			for (int i = 0; i < teacherList.Teachers.Count(); i++)
			{
				if (teacherList.Teachers[i].HumanAddress.City == City)
				{
					treeView1.Nodes[0].Nodes.Add(teacherList.Teachers[i].Surname);
					for (int j = 0; j < teacherList.Teachers[i].Students.Count(); j++)
					{
						if (teacherList.Teachers[i].Students[j].HumanAddress.City == City)
						{
							treeView1.Nodes[0].Nodes[i].Nodes.Add(teacherList.Teachers[i].Students[j].Surname);
						}
					}
				}
			}
		}
		public void initealeComboBox()
		{
			List<string> Cites = new List<string> { };
			ListCites(out Cites);
			for(int i = 0; i < Cites.Count(); i++)
			{
				this.CitycomboBox.Items.Add(Cites[i]);
			}
			this.CitycomboBox.Items.Add("All");

		}
		private void button1_Click(object sender, EventArgs e)
		{
			this.CitycomboBox.SelectedItem.ToString();
		}

		private void studentToolStripMenuItem_Click(object sender, EventArgs e)
		{
			addStudent.Show();
		}

		private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
		{
			addTeacher.Show();
		}
		void ConectStudentToTeacher(Student student, string teacher)
		{
			for(int i=0; i<teacherList.Teachers.Count(); i++)
			{
				if(teacherList.Teachers[i].Surname == teacher)
				{
					teacherList.Teachers[i].Students.Add(student);
					initealeTree();
					break;
				}
			}
		}
		void AddTeacher(Teacher teacher)
		{
			teacherList.Teachers.Add(teacher);
			initealeTree();
		}

		private void CitycomboBox_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			string SelectedCity = this.CitycomboBox.SelectedItem.ToString();
			if (InThisCitySomebodyLives(SelectedCity))
			{
				initealeTree(SelectedCity);
			}
			else
			{
				initealeTree();
			}
		}
		private bool InThisCitySomebodyLives(string City)
		{
			ListCites(out List<string> Cites);
			bool result = false;
			for(int i = 0; i < Cites.Count(); i++)
			{
				if (Cites[i] == City)
				{
					result = true;
					break;
				}
			}
			return (result);
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{

		}
	}
}
