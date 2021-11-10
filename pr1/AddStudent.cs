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
	public partial class AddStudent : Form
	{
		public string TeacherSurnsme = null; 
		public delegate void createstudent(Student student, string teacher);
		public event createstudent createstudentEvent;

		public AddStudent()
		{
			InitializeComponent();
		}
		private void radioButton_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton radioButton = (RadioButton)sender;
			TeacherSurnsme = radioButton.Text;
		}
		private void SaveButton_Click(object sender, EventArgs e)
		{
			bool TextBoxIsFilled = this.StudentAgeTextBox.Text != String.Empty || this.StudentNameTextBox.Text != String.Empty || this.StudentSernameTextBox.Text != String.Empty || this.StudentCountryTextBox.Text != String.Empty || this.StudentDistrictTextBox.Text != String.Empty || this.StudentCityTextBox.Text != String.Empty || this.StudentStreetTextBox.Text != String.Empty || this.StudentHousenumberTextBox.Text != String.Empty;
			int Age = 0;
			int Housenumber = 0;
			if (TextBoxIsFilled == true || TeacherSurnsme != null || int.TryParse(this.StudentHousenumberTextBox.Text,out Housenumber)|| int.TryParse(this.StudentAgeTextBox.Text, out Age))
			{

				Student student = new Student(this.StudentNameTextBox.Text, this.StudentSernameTextBox.Text, Age, new Address(this.StudentCountryTextBox.Text, this.StudentDistrictTextBox.Text, this.StudentCityTextBox.Text, this.StudentStreetTextBox.Text, Housenumber),new Mark());
				createstudentEvent?.Invoke(student, TeacherSurnsme);
				this.Close();
			}
			else
			{
				MessageBox.Show("not all fields are filled corect");
			}
		}

		private void AddStudent_Load(object sender, EventArgs e)
		{
			Form1 form = (Form1)this.Owner;
			for (int i = 0; i < form.teacherList.Teachers.Count(); i++)
			{
				RadioButton radioButton = new RadioButton();
				radioButton.Text = form.teacherList.Teachers[i].Surname;
				radioButton.Location = new Point(10, i * 20 + 15);
				radioButton.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
				this.TeachergroupBox.Controls.Add(radioButton);
			}
		}

		private void CanselButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
