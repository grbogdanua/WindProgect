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
	public partial class AddTeacher : Form
	{
		public delegate void createteacher(Teacher teacher);
		public event createteacher createteacherEvent;
		public AddTeacher()
		{
			InitializeComponent();
		}

		private void SaveAndHideButton_Click(object sender, EventArgs e)
		{
			bool TextBoxIsFilled = this.TeacherAgeTextBox.Text != String.Empty || this.TeacherNameTextBox.Text != String.Empty || this.TeacherSernameTextBox.Text != String.Empty || this.TeacherCountryTextBox.Text != String.Empty || this.TeacherDistrictTextBox.Text != String.Empty || this.TeacherCityTextBox.Text != String.Empty || this.TeacherStreetTextBox.Text != String.Empty || this.TeacherHousenumberTextBox.Text != String.Empty;
			int Age = 0;
			int Housenumber = 0;
			if (TextBoxIsFilled == true && int.TryParse(this.TeacherHousenumberTextBox.Text, out Housenumber) && int.TryParse(this.TeacherAgeTextBox.Text, out Age))
			{

				Teacher teacher = new Teacher(this.TeacherNameTextBox.Text, this.TeacherSernameTextBox.Text, Age, new Address(this.TeacherCountryTextBox.Text, this.TeacherDistrictTextBox.Text, this.TeacherCityTextBox.Text, this.TeacherStreetTextBox.Text, Housenumber));
				createteacherEvent?.Invoke(teacher);
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
			this.TeacherSernameTextBox.Text = randomizer.Surname();
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
			bool TextBoxIsFilled = this.TeacherAgeTextBox.Text != String.Empty || this.TeacherNameTextBox.Text != String.Empty || this.TeacherSernameTextBox.Text != String.Empty || this.TeacherCountryTextBox.Text != String.Empty || this.TeacherDistrictTextBox.Text != String.Empty || this.TeacherCityTextBox.Text != String.Empty || this.TeacherStreetTextBox.Text != String.Empty || this.TeacherHousenumberTextBox.Text != String.Empty;
			int Age = 0;
			int Housenumber = 0;
			if (TextBoxIsFilled == true && int.TryParse(this.TeacherHousenumberTextBox.Text, out Housenumber) && int.TryParse(this.TeacherAgeTextBox.Text, out Age))
			{

				Teacher teacher = new Teacher(this.TeacherNameTextBox.Text, this.TeacherSernameTextBox.Text, Age, new Address(this.TeacherCountryTextBox.Text, this.TeacherDistrictTextBox.Text, this.TeacherCityTextBox.Text, this.TeacherStreetTextBox.Text, Housenumber));
				createteacherEvent?.Invoke(teacher);
			}
			else
			{
				MessageBox.Show("not all fields are filled corect");
			}
		}
	}
}
