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
		public RadioButton teacher = null; 
		public delegate void createstudent(Student student, Teacher teacher);
		public event createstudent createstudentEvent;
		public TeacherList TeacherList { get; set; }

		public AddStudent()
		{
			InitializeComponent();
		}
		private void radioButton_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton radioButton = (RadioButton)sender;
			teacher = radioButton;
		}
		private void SaveAndHideButton_Click(object sender, EventArgs e)
		{
			bool TextBoxIsFilled = this.StudentAgeTextBox.Text != String.Empty || this.StudentNameTextBox.Text != String.Empty || this.StudentSernameTextBox.Text != String.Empty || this.StudentCountryTextBox.Text != String.Empty || this.StudentDistrictTextBox.Text != String.Empty || this.StudentCityTextBox.Text != String.Empty || this.StudentStreetTextBox.Text != String.Empty || this.StudentHousenumberTextBox.Text != String.Empty;
			int Age = 0;
			int Housenumber = 0;
			if (TextBoxIsFilled == true && teacher != null && int.TryParse(this.StudentHousenumberTextBox.Text,out Housenumber) && int.TryParse(this.StudentAgeTextBox.Text, out Age))
			{

				Student student = new Student(this.StudentNameTextBox.Text, this.StudentSernameTextBox.Text, Age, new Address(this.StudentCountryTextBox.Text, this.StudentDistrictTextBox.Text, this.StudentCityTextBox.Text, this.StudentStreetTextBox.Text, Housenumber),new Mark());
				createstudentEvent?.Invoke(student, (Teacher)teacher.Tag);
				this.Hide();
			}
			else
			{
				MessageBox.Show("not all fields are filled corect");
			}
		}

		private void AddStudent_Load(object sender, EventArgs e)
		{
			
		}

		private void CanselButton_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void randomize_Click(object sender, EventArgs e)
		{
			Randomizer randomizer = new Randomizer();
			this.StudentAgeTextBox.Text = randomizer.Age();
			this.StudentNameTextBox.Text = randomizer.Name();
			this.StudentSernameTextBox.Text = randomizer.Surname();
			this.StudentCountryTextBox.Text = randomizer.Country();
			this.StudentDistrictTextBox.Text = randomizer.District();
			this.StudentCityTextBox.Text = randomizer.City();
			this.StudentStreetTextBox.Text = randomizer.Street();
			this.StudentHousenumberTextBox.Text = randomizer.Housenumber();
		}

		private void AddStudent_Shown(object sender, EventArgs e)
		{
			for (int i = 0; i < TeacherList.Teachers.Count(); i++)
			{
				RadioButton radioButton = new RadioButton();
				radioButton.Text = TeacherList.Teachers[i].Surname;
				radioButton.Tag = TeacherList.Teachers[i];
				radioButton.Location = new Point(10, i * 20 + 15);
				radioButton.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
				this.TeachergroupBox.Controls.Add(radioButton);
				
			}
			this.StudentAgeTextBox.Text = string.Empty;
			this.StudentNameTextBox.Text = string.Empty;
			this.StudentSernameTextBox.Text = string.Empty;
			this.StudentCountryTextBox.Text = string.Empty;
			this.StudentDistrictTextBox.Text = string.Empty;
			this.StudentCityTextBox.Text = string.Empty;
			this.StudentStreetTextBox.Text = string.Empty;
			this.StudentHousenumberTextBox.Text = string.Empty;
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			bool TextBoxIsFilled = this.StudentAgeTextBox.Text != String.Empty || this.StudentNameTextBox.Text != String.Empty || this.StudentSernameTextBox.Text != String.Empty || this.StudentCountryTextBox.Text != String.Empty || this.StudentDistrictTextBox.Text != String.Empty || this.StudentCityTextBox.Text != String.Empty || this.StudentStreetTextBox.Text != String.Empty || this.StudentHousenumberTextBox.Text != String.Empty;
			int Age = 0;
			int Housenumber = 0;
			if (TextBoxIsFilled == true && teacher != null && int.TryParse(this.StudentHousenumberTextBox.Text, out Housenumber) && int.TryParse(this.StudentAgeTextBox.Text, out Age))
			{

				Student student = new Student(this.StudentNameTextBox.Text, this.StudentSernameTextBox.Text, Age, new Address(this.StudentCountryTextBox.Text, this.StudentDistrictTextBox.Text, this.StudentCityTextBox.Text, this.StudentStreetTextBox.Text, Housenumber), new Mark());
				createstudentEvent?.Invoke(student, (Teacher)teacher.Tag);
			}
			else
			{
				MessageBox.Show("not all fields are filled corect");
			}
		}
	}
}
