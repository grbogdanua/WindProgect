
namespace pr1
{
	partial class AddStudent
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.saveAndHideButton = new System.Windows.Forms.Button();
			this.CanselButton = new System.Windows.Forms.Button();
			this.StudentLable = new System.Windows.Forms.Label();
			this.StudentNameTextBox = new System.Windows.Forms.TextBox();
			this.StudentSernameTextBox = new System.Windows.Forms.TextBox();
			this.StudentAgeTextBox = new System.Windows.Forms.TextBox();
			this.NameStudentLable = new System.Windows.Forms.Label();
			this.SernameStudentLable = new System.Windows.Forms.Label();
			this.AgeStudentLable = new System.Windows.Forms.Label();
			this.StudentAddress = new System.Windows.Forms.Label();
			this.StudentCountry = new System.Windows.Forms.Label();
			this.StudentCountryTextBox = new System.Windows.Forms.TextBox();
			this.StudentDistrictTextBox = new System.Windows.Forms.TextBox();
			this.StudentDistrict = new System.Windows.Forms.Label();
			this.StudentCityTextBox = new System.Windows.Forms.TextBox();
			this.StudentCity = new System.Windows.Forms.Label();
			this.StudentStreetTextBox = new System.Windows.Forms.TextBox();
			this.StudentStreet = new System.Windows.Forms.Label();
			this.StudentHousenumberTextBox = new System.Windows.Forms.TextBox();
			this.StudentHousenumber = new System.Windows.Forms.Label();
			this.TeachergroupBox = new System.Windows.Forms.GroupBox();
			this.randomize = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.studentPictureBox = new System.Windows.Forms.PictureBox();
			this.addImageButton = new System.Windows.Forms.Button();
			this.FileDialog = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.studentPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// saveAndHideButton
			// 
			this.saveAndHideButton.Location = new System.Drawing.Point(169, 395);
			this.saveAndHideButton.Name = "saveAndHideButton";
			this.saveAndHideButton.Size = new System.Drawing.Size(98, 23);
			this.saveAndHideButton.TabIndex = 0;
			this.saveAndHideButton.Text = "Save And Close";
			this.saveAndHideButton.UseVisualStyleBackColor = true;
			this.saveAndHideButton.Click += new System.EventHandler(this.SaveAndHideButton_Click);
			// 
			// CanselButton
			// 
			this.CanselButton.Location = new System.Drawing.Point(430, 366);
			this.CanselButton.Name = "CanselButton";
			this.CanselButton.Size = new System.Drawing.Size(75, 23);
			this.CanselButton.TabIndex = 1;
			this.CanselButton.Text = "Cansel";
			this.CanselButton.UseVisualStyleBackColor = true;
			this.CanselButton.Click += new System.EventHandler(this.CanselButton_Click);
			// 
			// StudentLable
			// 
			this.StudentLable.AutoSize = true;
			this.StudentLable.Location = new System.Drawing.Point(116, 52);
			this.StudentLable.Name = "StudentLable";
			this.StudentLable.Size = new System.Drawing.Size(44, 13);
			this.StudentLable.TabIndex = 2;
			this.StudentLable.Text = "Student";
			// 
			// StudentNameTextBox
			// 
			this.StudentNameTextBox.Location = new System.Drawing.Point(108, 92);
			this.StudentNameTextBox.Name = "StudentNameTextBox";
			this.StudentNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.StudentNameTextBox.TabIndex = 3;
			// 
			// StudentSernameTextBox
			// 
			this.StudentSernameTextBox.Location = new System.Drawing.Point(108, 118);
			this.StudentSernameTextBox.Name = "StudentSernameTextBox";
			this.StudentSernameTextBox.Size = new System.Drawing.Size(100, 20);
			this.StudentSernameTextBox.TabIndex = 4;
			// 
			// StudentAgeTextBox
			// 
			this.StudentAgeTextBox.Location = new System.Drawing.Point(108, 145);
			this.StudentAgeTextBox.Name = "StudentAgeTextBox";
			this.StudentAgeTextBox.Size = new System.Drawing.Size(100, 20);
			this.StudentAgeTextBox.TabIndex = 5;
			// 
			// NameStudentLable
			// 
			this.NameStudentLable.AutoSize = true;
			this.NameStudentLable.Location = new System.Drawing.Point(48, 95);
			this.NameStudentLable.Name = "NameStudentLable";
			this.NameStudentLable.Size = new System.Drawing.Size(35, 13);
			this.NameStudentLable.TabIndex = 7;
			this.NameStudentLable.Text = "Name";
			// 
			// SernameStudentLable
			// 
			this.SernameStudentLable.AutoSize = true;
			this.SernameStudentLable.Location = new System.Drawing.Point(48, 124);
			this.SernameStudentLable.Name = "SernameStudentLable";
			this.SernameStudentLable.Size = new System.Drawing.Size(49, 13);
			this.SernameStudentLable.TabIndex = 8;
			this.SernameStudentLable.Text = "Sername";
			// 
			// AgeStudentLable
			// 
			this.AgeStudentLable.AutoSize = true;
			this.AgeStudentLable.Location = new System.Drawing.Point(51, 151);
			this.AgeStudentLable.Name = "AgeStudentLable";
			this.AgeStudentLable.Size = new System.Drawing.Size(26, 13);
			this.AgeStudentLable.TabIndex = 9;
			this.AgeStudentLable.Text = "Age";
			// 
			// StudentAddress
			// 
			this.StudentAddress.AutoSize = true;
			this.StudentAddress.Location = new System.Drawing.Point(343, 51);
			this.StudentAddress.Name = "StudentAddress";
			this.StudentAddress.Size = new System.Drawing.Size(45, 13);
			this.StudentAddress.TabIndex = 10;
			this.StudentAddress.Text = "Address";
			// 
			// StudentCountry
			// 
			this.StudentCountry.AutoSize = true;
			this.StudentCountry.Location = new System.Drawing.Point(273, 98);
			this.StudentCountry.Name = "StudentCountry";
			this.StudentCountry.Size = new System.Drawing.Size(43, 13);
			this.StudentCountry.TabIndex = 11;
			this.StudentCountry.Text = "Country";
			// 
			// StudentCountryTextBox
			// 
			this.StudentCountryTextBox.Location = new System.Drawing.Point(346, 91);
			this.StudentCountryTextBox.Name = "StudentCountryTextBox";
			this.StudentCountryTextBox.Size = new System.Drawing.Size(100, 20);
			this.StudentCountryTextBox.TabIndex = 12;
			// 
			// StudentDistrictTextBox
			// 
			this.StudentDistrictTextBox.Location = new System.Drawing.Point(346, 118);
			this.StudentDistrictTextBox.Name = "StudentDistrictTextBox";
			this.StudentDistrictTextBox.Size = new System.Drawing.Size(100, 20);
			this.StudentDistrictTextBox.TabIndex = 14;
			// 
			// StudentDistrict
			// 
			this.StudentDistrict.AutoSize = true;
			this.StudentDistrict.Location = new System.Drawing.Point(273, 124);
			this.StudentDistrict.Name = "StudentDistrict";
			this.StudentDistrict.Size = new System.Drawing.Size(39, 13);
			this.StudentDistrict.TabIndex = 13;
			this.StudentDistrict.Text = "District";
			// 
			// StudentCityTextBox
			// 
			this.StudentCityTextBox.Location = new System.Drawing.Point(346, 144);
			this.StudentCityTextBox.Name = "StudentCityTextBox";
			this.StudentCityTextBox.Size = new System.Drawing.Size(100, 20);
			this.StudentCityTextBox.TabIndex = 16;
			// 
			// StudentCity
			// 
			this.StudentCity.AutoSize = true;
			this.StudentCity.Location = new System.Drawing.Point(273, 151);
			this.StudentCity.Name = "StudentCity";
			this.StudentCity.Size = new System.Drawing.Size(24, 13);
			this.StudentCity.TabIndex = 15;
			this.StudentCity.Text = "City";
			// 
			// StudentStreetTextBox
			// 
			this.StudentStreetTextBox.Location = new System.Drawing.Point(346, 170);
			this.StudentStreetTextBox.Name = "StudentStreetTextBox";
			this.StudentStreetTextBox.Size = new System.Drawing.Size(100, 20);
			this.StudentStreetTextBox.TabIndex = 18;
			// 
			// StudentStreet
			// 
			this.StudentStreet.AutoSize = true;
			this.StudentStreet.Location = new System.Drawing.Point(273, 177);
			this.StudentStreet.Name = "StudentStreet";
			this.StudentStreet.Size = new System.Drawing.Size(35, 13);
			this.StudentStreet.TabIndex = 17;
			this.StudentStreet.Text = "Street";
			// 
			// StudentHousenumberTextBox
			// 
			this.StudentHousenumberTextBox.Location = new System.Drawing.Point(346, 196);
			this.StudentHousenumberTextBox.Name = "StudentHousenumberTextBox";
			this.StudentHousenumberTextBox.Size = new System.Drawing.Size(100, 20);
			this.StudentHousenumberTextBox.TabIndex = 20;
			// 
			// StudentHousenumber
			// 
			this.StudentHousenumber.AutoSize = true;
			this.StudentHousenumber.Location = new System.Drawing.Point(273, 203);
			this.StudentHousenumber.Name = "StudentHousenumber";
			this.StudentHousenumber.Size = new System.Drawing.Size(65, 13);
			this.StudentHousenumber.TabIndex = 19;
			this.StudentHousenumber.Text = "Housenuber";
			// 
			// TeachergroupBox
			// 
			this.TeachergroupBox.Location = new System.Drawing.Point(452, 51);
			this.TeachergroupBox.Name = "TeachergroupBox";
			this.TeachergroupBox.Size = new System.Drawing.Size(96, 268);
			this.TeachergroupBox.TabIndex = 21;
			this.TeachergroupBox.TabStop = false;
			this.TeachergroupBox.Text = "Teachers";
			// 
			// randomize
			// 
			this.randomize.Location = new System.Drawing.Point(274, 325);
			this.randomize.Name = "randomize";
			this.randomize.Size = new System.Drawing.Size(75, 23);
			this.randomize.TabIndex = 22;
			this.randomize.Text = "Randomize";
			this.randomize.UseVisualStyleBackColor = true;
			this.randomize.Click += new System.EventHandler(this.randomize_Click);
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(169, 366);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(98, 23);
			this.saveButton.TabIndex = 23;
			this.saveButton.Text = "Add";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// studentPictureBox
			// 
			this.studentPictureBox.Location = new System.Drawing.Point(555, 52);
			this.studentPictureBox.Name = "studentPictureBox";
			this.studentPictureBox.Size = new System.Drawing.Size(207, 267);
			this.studentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.studentPictureBox.TabIndex = 24;
			this.studentPictureBox.TabStop = false;
			// 
			// addImageButton
			// 
			this.addImageButton.Location = new System.Drawing.Point(355, 325);
			this.addImageButton.Name = "addImageButton";
			this.addImageButton.Size = new System.Drawing.Size(75, 23);
			this.addImageButton.TabIndex = 44;
			this.addImageButton.Text = "Add Image";
			this.addImageButton.UseVisualStyleBackColor = true;
			this.addImageButton.Click += new System.EventHandler(this.addImageButton_Click);
			// 
			// FileDialog
			// 
			this.FileDialog.Filter = "jpg files (*.jpg)|*.jpg";
			this.FileDialog.Title = "Image";
			// 
			// AddStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(815, 450);
			this.Controls.Add(this.addImageButton);
			this.Controls.Add(this.studentPictureBox);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.randomize);
			this.Controls.Add(this.TeachergroupBox);
			this.Controls.Add(this.StudentHousenumberTextBox);
			this.Controls.Add(this.StudentHousenumber);
			this.Controls.Add(this.StudentStreetTextBox);
			this.Controls.Add(this.StudentStreet);
			this.Controls.Add(this.StudentCityTextBox);
			this.Controls.Add(this.StudentCity);
			this.Controls.Add(this.StudentDistrictTextBox);
			this.Controls.Add(this.StudentDistrict);
			this.Controls.Add(this.StudentCountryTextBox);
			this.Controls.Add(this.StudentCountry);
			this.Controls.Add(this.StudentAddress);
			this.Controls.Add(this.AgeStudentLable);
			this.Controls.Add(this.SernameStudentLable);
			this.Controls.Add(this.NameStudentLable);
			this.Controls.Add(this.StudentAgeTextBox);
			this.Controls.Add(this.StudentSernameTextBox);
			this.Controls.Add(this.StudentNameTextBox);
			this.Controls.Add(this.StudentLable);
			this.Controls.Add(this.CanselButton);
			this.Controls.Add(this.saveAndHideButton);
			this.Name = "AddStudent";
			this.Text = "AddStudent";
			this.Load += new System.EventHandler(this.AddStudent_Load);
			this.Shown += new System.EventHandler(this.AddStudent_Shown);
			this.VisibleChanged += new System.EventHandler(this.AddStudent_Shown);
			((System.ComponentModel.ISupportInitialize)(this.studentPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button saveAndHideButton;
		private System.Windows.Forms.Button CanselButton;
		private System.Windows.Forms.Label StudentLable;
		private System.Windows.Forms.TextBox StudentNameTextBox;
		private System.Windows.Forms.TextBox StudentSernameTextBox;
		private System.Windows.Forms.TextBox StudentAgeTextBox;
		private System.Windows.Forms.Label NameStudentLable;
		private System.Windows.Forms.Label SernameStudentLable;
		private System.Windows.Forms.Label AgeStudentLable;
		private System.Windows.Forms.Label StudentAddress;
		private System.Windows.Forms.Label StudentCountry;
		private System.Windows.Forms.TextBox StudentCountryTextBox;
		private System.Windows.Forms.TextBox StudentDistrictTextBox;
		private System.Windows.Forms.Label StudentDistrict;
		private System.Windows.Forms.TextBox StudentCityTextBox;
		private System.Windows.Forms.Label StudentCity;
		private System.Windows.Forms.TextBox StudentStreetTextBox;
		private System.Windows.Forms.Label StudentStreet;
		private System.Windows.Forms.TextBox StudentHousenumberTextBox;
		private System.Windows.Forms.Label StudentHousenumber;
		private System.Windows.Forms.GroupBox TeachergroupBox;
		private System.Windows.Forms.Button randomize;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.PictureBox studentPictureBox;
		private System.Windows.Forms.Button addImageButton;
		private System.Windows.Forms.OpenFileDialog FileDialog;
	}
}