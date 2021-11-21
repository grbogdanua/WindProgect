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
		public Teacher selectedTeacher = null;
		public delegate void createstudent();
		public event createstudent createstudentEvent;
		public string curentImageAddress;
		public string imageAddress;
		public static DirectoryInfo di;
		private static string pathImage = "Files\\Image\\";
		private TeacherList _curentTeacherList;
		public TeacherList TeacherList
		{
			set
			{
				_curentTeacherList = value;
				TeacherListApdated();
			}
		}
		private Student _currentStudent;
		public Student Student { 
			set
			{
				_currentStudent = value;
				StudentApdated();
			}
				}

		public StudentForm()
		{
			InitializeComponent();
		}
		private void radioButton_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton radioButton = (RadioButton)sender;
			selectedTeacher = (Teacher)radioButton.Tag;
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
				selectedTeacher != null &&
				int.TryParse(this.StudentHousenumberTextBox.Text, out Housenumber) &&
				int.TryParse(this.StudentAgeTextBox.Text, out Age))
			{
				Copy();
				_currentStudent.Name = this.StudentNameTextBox.Text;
				_currentStudent.Surname = this.StudentSernameTextBox.Text;
				_currentStudent.Age = Age;
				_currentStudent.HumanAddress.Country = this.StudentCountryTextBox.Text;
				_currentStudent.HumanAddress.District = this.StudentDistrictTextBox.Text;
				_currentStudent.HumanAddress.City = this.StudentCityTextBox.Text;
				_currentStudent.HumanAddress.Street = this.StudentStreetTextBox.Text;
				_currentStudent.HumanAddress.Housenumber = Housenumber;
				_currentStudent.ImageAddress = imageAddress;
				this.Hide();
				int index;
				if (IsNew(out index))
				{
					selectedTeacher.Students.Add(_currentStudent);
				}
				else if(_curentTeacherList.Teachers[index] != selectedTeacher)
				{
					_curentTeacherList.Teachers[index].Students.Remove(_currentStudent);
					selectedTeacher.Students.Add(_currentStudent);
				}
				createstudentEvent?.Invoke();
			}
			else
			{
				MessageBox.Show("not all fields are filled corect");
			}
		}
		private bool IsNew(out int i)
		{
			bool isNew = true;
			for (i = 0; i < _curentTeacherList.Teachers.Count(); i++)
			{
				if (_curentTeacherList.Teachers[i].Students.Contains(_currentStudent))
				{
					isNew = false;
					break;
				}
			}
			return (isNew);
		}

		private void StudentForm_Shown(object sender, EventArgs e)
		{
			this.TeachergroupBox.Controls.Clear();
			for (int i = 0; i < _curentTeacherList.Teachers.Count(); i++)
			{
				RadioButton radioButton = new RadioButton();
				radioButton.Text = _curentTeacherList.Teachers[i].Surname;
				radioButton.Tag = _curentTeacherList.Teachers[i];
				radioButton.Location = new Point(10, i * 20 + 15);
				radioButton.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
				if (_curentTeacherList.Teachers[i].Students.Contains(_currentStudent))
				{
					radioButton.Checked = true;
				}
				this.TeachergroupBox.Controls.Add(radioButton);
				
			}
			this.StudentAgeTextBox.Text = _currentStudent.Age.ToString();
			this.StudentNameTextBox.Text = _currentStudent.Name;
			this.StudentSernameTextBox.Text = _currentStudent.Surname;
			this.StudentCountryTextBox.Text = _currentStudent.HumanAddress.Country;
			this.StudentDistrictTextBox.Text = _currentStudent.HumanAddress.District;
			this.StudentCityTextBox.Text = _currentStudent.HumanAddress.City;
			this.StudentStreetTextBox.Text = _currentStudent.HumanAddress.Street;
			this.StudentHousenumberTextBox.Text = _currentStudent.HumanAddress.Housenumber.ToString();
			try
			{
				this.studentPictureBox.Image = Image.FromFile(_currentStudent.ImageAddress);
			}
			catch
			{
				this.studentPictureBox.Image = Image.FromFile("Files\\Image\\anonym.jpg");
			}
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
		private void StudentApdated()
		{
			if(_currentStudent == null)
			{
				this.randomize.Visible = false;
				this.deleteButton.Visible = false;
				this.saveButton.Visible = true;
				this.StudentAgeTextBox.Text = "";
				this.StudentNameTextBox.Text = "";
				this.StudentSernameTextBox.Text = "";
				this.StudentCountryTextBox.Text = "";
				this.StudentDistrictTextBox.Text = "";
				this.StudentCityTextBox.Text = "";
				this.StudentStreetTextBox.Text = "";
				this.StudentHousenumberTextBox.Text = "";
				this.studentPictureBox.Image = Image.FromFile("Files\\Image\\anonym.jpg");
			}
			else
			{
				this.randomize.Visible = true;
				this.deleteButton.Visible = true;
				this.saveButton.Visible = false;
				foreach (RadioButton radioButton in this.TeachergroupBox.Controls)
				{
					var teacher = (Teacher)radioButton.Tag;
					if (teacher.Students.Contains(_currentStudent))
					{
						radioButton.Checked = true;
					}
					else
					{
						radioButton.Checked = false;
					}
				}
				this.StudentAgeTextBox.Text = _currentStudent.Age.ToString();
				this.StudentNameTextBox.Text = _currentStudent.Name;
				this.StudentSernameTextBox.Text = _currentStudent.Surname;
				this.StudentCountryTextBox.Text = _currentStudent.HumanAddress.Country;
				this.StudentDistrictTextBox.Text = _currentStudent.HumanAddress.District;
				this.StudentCityTextBox.Text = _currentStudent.HumanAddress.City;
				this.StudentStreetTextBox.Text = _currentStudent.HumanAddress.Street;
				this.StudentHousenumberTextBox.Text = _currentStudent.HumanAddress.Housenumber.ToString();
				try
				{
					this.studentPictureBox.Image = Image.FromFile(_currentStudent.ImageAddress);
				}
				catch
				{
					this.studentPictureBox.Image = Image.FromFile("Files\\Image\\anonym.jpg");
				}
			}
			
		}
		private void TeacherListApdated()
		{
			this.TeachergroupBox.Controls.Clear();
			for (int i = 0; i < _curentTeacherList.Teachers.Count(); i++)
			{
				RadioButton radioButton = new RadioButton();
				radioButton.Text = _curentTeacherList.Teachers[i].Surname;
				radioButton.Tag = _curentTeacherList.Teachers[i];
				radioButton.Location = new Point(10, i * 20 + 15);
				radioButton.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
				this.TeachergroupBox.Controls.Add(radioButton);
			}
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			var userAnswer = MessageBox.Show("Are you shure?", "Confirmation", MessageBoxButtons.YesNo);
			if (userAnswer == DialogResult.Yes)
			{
				for (int i = 0; i < _curentTeacherList.Teachers.Count(); i++)
				{
					if (_curentTeacherList.Teachers[i].Students.Contains(_currentStudent))
					{
						_curentTeacherList.Teachers[i].Students.Remove(_currentStudent);
						break;
					}
				}
				this.Hide();
			}
		}
	}
}