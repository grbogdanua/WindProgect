using System;
using System.IO;
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
	public partial class StudentForm : Form
	{
		public RadioButton teacher = null;
		public delegate void createstudent(Student student, Teacher teacher);
		public event createstudent createstudentEvent;
		public string curentImageAddress;
		public string imageAddress;
		public static DirectoryInfo di;
		private static string pathImage = "Files\\Image\\";
		public TeacherList TeacherList { get; set; }
		public Student Student { get; set; }

		public StudentForm()
		{
			InitializeComponent();
		}
		private void radioButton_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton radioButton = (RadioButton)sender;
			teacher = radioButton;
		}
		private void SaveChengesButton_Click(object sender, EventArgs e)
		{
			bool TextBoxIsFilled = this.StudentAgeTextBox.Text != String.Empty ||
				this.StudentNameTextBox.Text != String.Empty ||
				this.StudentSernameTextBox.Text != String.Empty ||
				this.StudentCountryTextBox.Text != String.Empty ||
				this.StudentDistrictTextBox.Text != String.Empty ||
				this.StudentCityTextBox.Text != String.Empty ||
				this.StudentStreetTextBox.Text != String.Empty ||
				this.StudentHousenumberTextBox.Text != String.Empty;
			int Age = 0;
			int Housenumber = 0;
			if (curentImageAddress != String.Empty &&
				TextBoxIsFilled == true &&
				teacher != null &&
				int.TryParse(this.StudentHousenumberTextBox.Text, out Housenumber) &&
				int.TryParse(this.StudentAgeTextBox.Text, out Age))
			{
				Copy();
				Student.Name = this.StudentNameTextBox.Text;
				Student.Surname = this.StudentSernameTextBox.Text;
				Student.Age = Age;
				Student.HumanAddress.Country = this.StudentCountryTextBox.Text;
				Student.HumanAddress.District = this.StudentDistrictTextBox.Text;
				Student.HumanAddress.City = this.StudentCityTextBox.Text;
				Student.HumanAddress.Street = this.StudentStreetTextBox.Text;
				Student.HumanAddress.Housenumber = Housenumber;
				Student.ImageAddress = imageAddress;
				this.Hide();
			}
			else
			{
				MessageBox.Show("not all fields are filled corect");
			}
		}


		private void StudentForm_Shown(object sender, EventArgs e)
		{
			for (int i = 0; i < TeacherList.Teachers.Count(); i++)
			{
				RadioButton radioButton = new RadioButton();
				radioButton.Text = TeacherList.Teachers[i].Surname;
				radioButton.Tag = TeacherList.Teachers[i];
				radioButton.Location = new Point(10, i * 20 + 15);
				radioButton.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
				if (TeacherList.Teachers[i].Students.Contains(Student))
				{
					radioButton.Checked = true;
				}
				this.TeachergroupBox.Controls.Add(radioButton);
				
			}
			this.StudentAgeTextBox.Text = Student.Age.ToString();
			this.StudentNameTextBox.Text = Student.Name;
			this.StudentSernameTextBox.Text = Student.Surname;
			this.StudentCountryTextBox.Text = Student.HumanAddress.Country;
			this.StudentDistrictTextBox.Text = Student.HumanAddress.District;
			this.StudentCityTextBox.Text = Student.HumanAddress.City;
			this.StudentStreetTextBox.Text = Student.HumanAddress.Street;
			this.StudentHousenumberTextBox.Text = Student.HumanAddress.Housenumber.ToString();
			if (Student.ImageAddress != null)
			{
				this.studentPictureBox.Image = Image.FromFile(Student.ImageAddress);
			}
			else { this.studentPictureBox.Image = Image.FromFile("Files\\Image\\anonym.jpg"); }
		}

		/*private void SaveButton_Click(object sender, EventArgs e)
		{
			bool TextBoxIsFilled = this.StudentAgeTextBox.Text != String.Empty ||
				this.StudentNameTextBox.Text != String.Empty ||
				this.StudentSernameTextBox.Text != String.Empty ||
				this.StudentCountryTextBox.Text != String.Empty ||
				this.StudentDistrictTextBox.Text != String.Empty ||
				this.StudentCityTextBox.Text != String.Empty ||
				this.StudentStreetTextBox.Text != String.Empty ||
				this.StudentHousenumberTextBox.Text != String.Empty;
			int Age = 0;
			int Housenumber = 0;
			if (curentImageAddress != String.Empty &&
				TextBoxIsFilled == true &&
				teacher != null &&
				int.TryParse(this.StudentHousenumberTextBox.Text, out Housenumber) &&
				int.TryParse(this.StudentAgeTextBox.Text, out Age))
			{
				Copy();
				Student.Name = this.StudentNameTextBox.Text;
				Student.Surname = this.StudentSernameTextBox.Text;
				Student.Age = Age;
				Student.HumanAddress.Country = this.StudentCountryTextBox.Text;
				Student.HumanAddress.District = this.StudentDistrictTextBox.Text;
				Student.HumanAddress.City = this.StudentCityTextBox.Text;
				Student.HumanAddress.Street = this.StudentStreetTextBox.Text;
				Student.HumanAddress.Housenumber = Housenumber;
				Student.ImageAddress = imageAddress;
				//createstudentEvent?.Invoke(student, (Teacher)teacher.Tag);
			}
			else
			{
				MessageBox.Show("not all fields are filled corect");
			}
		}*/
		private void Copy()
		{
			string[] separator = { "\\" };
			string[] path = curentImageAddress.Split(separator, StringSplitOptions.None);
			string imageName = path[path.Length - 1];
			Random random = new Random();
			string fileName = Convert.ToString(random.Next(1, 999));
			while (File.Exists(Path.Combine(new string[] { pathImage,fileName,imageName })))
			{
				fileName = Convert.ToString(random.Next(1, 999));
			}
			di = Directory.CreateDirectory(Path.Combine(new string[] { pathImage, fileName}));
			imageAddress = Path.Combine(new string[] { pathImage, fileName, imageName });
			this.studentPictureBox.Image = Image.FromFile(curentImageAddress);
			File.Copy(curentImageAddress, imageAddress);
		}
		private void ChengeImageButton_Click(object sender, EventArgs e)
		{
			DialogResult dr = this.FileDialog.ShowDialog();
			if (dr == DialogResult.OK)
			{
				curentImageAddress = FileDialog.FileName;
				//MessageBox.Show(curentImage);
				this.studentPictureBox.Image = Image.FromFile(curentImageAddress);
				//File.Copy(curentImage, imageAddress);
			}
		}
		private void canselStudentButon_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}