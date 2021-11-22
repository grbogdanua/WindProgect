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
	public partial class TeacherForm : Form
	{
		public delegate void createteacher();
		public event createteacher createteacherEvent;
		public string curentImageAddress;
		public string imageAddress;
		public static DirectoryInfo di;
		private TeacherList _curentTeacherList;
		public TeacherList TeacherList
		{
			set
			{
				_curentTeacherList = value;
			}
		}
		private Teacher _currentTeacher;
		public Teacher Student
		{
			set
			{
				_currentTeacher = value;
				TeacherApdated();
			}
		}
		public TeacherForm()
		{
			InitializeComponent();
		}

		private void SaveAndHideButton_Click(object sender, EventArgs e)
		{
			bool TextBoxIsFilled = this.TeacherAgeTextBox.Text != String.Empty || this.TeacherNameTextBox.Text != String.Empty || this.TeacherSurnameTextBox.Text != String.Empty || this.TeacherCountryTextBox.Text != String.Empty || this.TeacherDistrictTextBox.Text != String.Empty || this.TeacherCityTextBox.Text != String.Empty || this.TeacherStreetTextBox.Text != String.Empty || this.TeacherHousenumberTextBox.Text != String.Empty;
			int Age = 0;
			int Housenumber = 0;
			if (curentImageAddress != null && TextBoxIsFilled == true && int.TryParse(this.TeacherHousenumberTextBox.Text, out Housenumber) && int.TryParse(this.TeacherAgeTextBox.Text, out Age))
			{
				Copy();
				Teacher teacher = new Teacher(this.TeacherNameTextBox.Text, this.TeacherSurnameTextBox.Text, Age, imageAddress, new Address(this.TeacherCountryTextBox.Text, this.TeacherDistrictTextBox.Text, this.TeacherCityTextBox.Text, this.TeacherStreetTextBox.Text, Housenumber));
				createteacherEvent?.Invoke();
				this.Hide();
			}
			else
			{
				MessageBox.Show("not all fields are filled corect");
			}
		}

		private void randomize_Click(object sender, EventArgs e)
		{
			Randomizer randomizer = new Randomizer();
			this.TeacherAgeTextBox.Text = randomizer.Age();
			this.TeacherNameTextBox.Text = randomizer.Name();
			this.TeacherSurnameTextBox.Text = randomizer.Surname();
			this.TeacherCountryTextBox.Text = randomizer.Country();
			this.TeacherDistrictTextBox.Text = randomizer.District();
			this.TeacherCityTextBox.Text = randomizer.City();
			this.TeacherStreetTextBox.Text = randomizer.Street();
			this.TeacherHousenumberTextBox.Text = randomizer.Housenumber();
		}

		private void CanselButton_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			bool TextBoxIsFilled = this.TeacherAgeTextBox.Text != String.Empty || this.TeacherNameTextBox.Text != String.Empty || this.TeacherSurnameTextBox.Text != String.Empty || this.TeacherCountryTextBox.Text != String.Empty || this.TeacherDistrictTextBox.Text != String.Empty || this.TeacherCityTextBox.Text != String.Empty || this.TeacherStreetTextBox.Text != String.Empty || this.TeacherHousenumberTextBox.Text != String.Empty;
			int Age = 0;
			int Housenumber = 0;
			if (curentImageAddress != String.Empty && TextBoxIsFilled == true && int.TryParse(this.TeacherHousenumberTextBox.Text, out Housenumber) && int.TryParse(this.TeacherAgeTextBox.Text, out Age))
			{
				Copy();
				Teacher teacher = new Teacher(this.TeacherNameTextBox.Text, this.TeacherSurnameTextBox.Text, Age, imageAddress, new Address(this.TeacherCountryTextBox.Text, this.TeacherDistrictTextBox.Text, this.TeacherCityTextBox.Text, this.TeacherStreetTextBox.Text, Housenumber));
				createteacherEvent?.Invoke();
			}
			else
			{
				MessageBox.Show("not all fields are filled corect");
			}
		}

		private void AddTeacher_Shown(object sender, EventArgs e)
		{
			this.TeacherAgeTextBox.Text = String.Empty;
			this.TeacherNameTextBox.Text = String.Empty;
			this.TeacherSurnameTextBox.Text = String.Empty;
			this.TeacherCountryTextBox.Text = String.Empty;
			this.TeacherDistrictTextBox.Text = String.Empty;
			this.TeacherCityTextBox.Text = String.Empty;
			this.TeacherStreetTextBox.Text = String.Empty;
			this.TeacherHousenumberTextBox.Text = String.Empty;
			this.teacherPictureBox.Image = Image.FromFile("Files\\Image\\anonym.jpg");
		}
		private void Copy()
		{
			string[] separator = { "\\" };
			string[] path = curentImageAddress.Split(separator, StringSplitOptions.None);
			string imageName = path[path.Length - 1];
			Random random = new Random();
			string fileName = Convert.ToString(random.Next(1, 999));
			while (File.Exists("Files\\Image\\" + fileName + "\\" + imageName))
			{
				fileName = Convert.ToString(random.Next(1, 999));
			}
			di = Directory.CreateDirectory("Files\\Image\\" + fileName);
			imageAddress = "Files\\Image\\" + fileName + "\\" + imageName;
			File.Copy(curentImageAddress, imageAddress);
		}
		private void addImageButton_Click(object sender, EventArgs e)
		{
			DialogResult dr = this.FileDialog.ShowDialog();
			if(dr == DialogResult.OK)
			{
				curentImageAddress = FileDialog.FileName;
				this.teacherPictureBox.Image = Image.FromFile(curentImageAddress);
				//MessageBox.Show(curentImage);
				//File.Copy(curentImage, imageAddress);
			}
		}

		private void teacherDeleteButton_Click(object sender, EventArgs e)
		{
			var userAnswer = MessageBox.Show("Are you shure?", "Confirmation", MessageBoxButtons.YesNo);
			if (userAnswer == DialogResult.Yes)
			{
				
				if (_curentTeacherList.Teachers.Contains(_currentTeacher))
				{
					_curentTeacherList.Teachers.Remove(_currentTeacher);
				}
				
				createteacherEvent?.Invoke();
				this.Hide();
			}
		}
		private void TeacherApdated()
		{
			if (_currentTeacher == null)
			{
				this.TeacherAgeTextBox.Text = String.Empty;
				this.TeacherNameTextBox.Text = String.Empty;
				this.TeacherSurnameTextBox.Text = String.Empty;
				this.TeacherCountryTextBox.Text = String.Empty;
				this.TeacherDistrictTextBox.Text = String.Empty;
				this.TeacherCityTextBox.Text = String.Empty;
				this.TeacherStreetTextBox.Text = String.Empty;
				this.TeacherHousenumberTextBox.Text = String.Empty;
				this.teacherPictureBox.Image = Image.FromFile("Files\\Image\\anonym.jpg");
			}
			else
			{
				this.TeacherAgeTextBox.Text = _currentTeacher.Age.ToString();
				this.TeacherNameTextBox.Text = _currentTeacher.Name;
				this.TeacherSurnameTextBox.Text = _currentTeacher.Surname;
				this.TeacherCountryTextBox.Text = _currentTeacher.HumanAddress.Country;
				this.TeacherDistrictTextBox.Text = _currentTeacher.HumanAddress.District;
				this.TeacherCityTextBox.Text = _currentTeacher.HumanAddress.City;
				this.TeacherStreetTextBox.Text = _currentTeacher.HumanAddress.Street;
				this.TeacherHousenumberTextBox.Text = _currentTeacher.HumanAddress.Housenumber.ToString();
				try
				{
					this.teacherPictureBox.Image = Image.FromFile(_currentTeacher.ImageAddress);
				}
				catch
				{
					this.teacherPictureBox.Image = Image.FromFile("Files\\Image\\anonym.jpg");
				}
			}
		}
	}
}
