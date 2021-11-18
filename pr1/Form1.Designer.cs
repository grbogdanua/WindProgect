
namespace pr1
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.CitycomboBox = new System.Windows.Forms.ComboBox();
			this.showSelected = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.teacherListView = new System.Windows.Forms.ListView();
			this.TeacherID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TeacherSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TeacherName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TeacherAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TeacherCountStudents = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TeacherCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TeacherStrit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TeacherHouseNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.studentListView = new System.Windows.Forms.ListView();
			this.StudentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.StudentSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.StudentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.StudentAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.StudentMark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.StudentCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.StudentStrit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.StudentHouseNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.CheckBoxes = true;
			this.treeView1.Location = new System.Drawing.Point(8, 45);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(170, 390);
			this.treeView1.TabIndex = 2;
			// 
			// CitycomboBox
			// 
			this.CitycomboBox.FormattingEnabled = true;
			this.CitycomboBox.Location = new System.Drawing.Point(184, 45);
			this.CitycomboBox.Name = "CitycomboBox";
			this.CitycomboBox.Size = new System.Drawing.Size(169, 21);
			this.CitycomboBox.TabIndex = 3;
			this.CitycomboBox.SelectedIndexChanged += new System.EventHandler(this.CitycomboBox_SelectedIndexChanged_1);
			// 
			// showSelected
			// 
			this.showSelected.Location = new System.Drawing.Point(184, 91);
			this.showSelected.Name = "showSelected";
			this.showSelected.Size = new System.Drawing.Size(99, 23);
			this.showSelected.TabIndex = 4;
			this.showSelected.Text = "Show selected";
			this.showSelected.UseVisualStyleBackColor = true;
			this.showSelected.Click += new System.EventHandler(this.ShowSelected_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(880, 24);
			this.menuStrip1.TabIndex = 7;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teacherToolStripMenuItem,
            this.studentToolStripMenuItem});
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.newToolStripMenuItem.Text = "New";
			// 
			// teacherToolStripMenuItem
			// 
			this.teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
			this.teacherToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.teacherToolStripMenuItem.Text = "teacher";
			this.teacherToolStripMenuItem.Click += new System.EventHandler(this.TeacherToolStripMenuItem_Click);
			// 
			// studentToolStripMenuItem
			// 
			this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
			this.studentToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.studentToolStripMenuItem.Text = "student";
			this.studentToolStripMenuItem.Click += new System.EventHandler(this.StudentToolStripMenuItem_Click);
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.loadToolStripMenuItem.Text = "Load";
			this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(185, 211);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(168, 224);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// teacherListView
			// 
			this.teacherListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TeacherID,
            this.TeacherSurname,
            this.TeacherName,
            this.TeacherAge,
            this.TeacherCountStudents,
            this.TeacherCity,
            this.TeacherStrit,
            this.TeacherHouseNumber});
			this.teacherListView.FullRowSelect = true;
			this.teacherListView.HideSelection = false;
			this.teacherListView.Location = new System.Drawing.Point(359, 45);
			this.teacherListView.Name = "teacherListView";
			this.teacherListView.Size = new System.Drawing.Size(509, 190);
			this.teacherListView.TabIndex = 10;
			this.teacherListView.UseCompatibleStateImageBehavior = false;
			this.teacherListView.View = System.Windows.Forms.View.Details;
			this.teacherListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListView_MouseClick);
			this.teacherListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_MouseDoubleClick);
			// 
			// TeacherID
			// 
			this.TeacherID.Text = "ID";
			this.TeacherID.Width = 30;
			// 
			// TeacherSurname
			// 
			this.TeacherSurname.Text = "Surname";
			// 
			// TeacherName
			// 
			this.TeacherName.Text = "Name";
			// 
			// TeacherAge
			// 
			this.TeacherAge.Text = "Age";
			this.TeacherAge.Width = 40;
			// 
			// TeacherCountStudents
			// 
			this.TeacherCountStudents.Text = "Count Students";
			this.TeacherCountStudents.Width = 100;
			// 
			// TeacherCity
			// 
			this.TeacherCity.Text = "City";
			// 
			// TeacherStrit
			// 
			this.TeacherStrit.Text = "Strit";
			// 
			// TeacherHouseNumber
			// 
			this.TeacherHouseNumber.Text = "House Number";
			this.TeacherHouseNumber.Width = 100;
			// 
			// studentListView
			// 
			this.studentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StudentID,
            this.StudentSurname,
            this.StudentName,
            this.StudentAge,
            this.StudentMark,
            this.StudentCity,
            this.StudentStrit,
            this.StudentHouseNumber});
			this.studentListView.FullRowSelect = true;
			this.studentListView.HideSelection = false;
			this.studentListView.Location = new System.Drawing.Point(359, 242);
			this.studentListView.Name = "studentListView";
			this.studentListView.Size = new System.Drawing.Size(509, 193);
			this.studentListView.TabIndex = 11;
			this.studentListView.UseCompatibleStateImageBehavior = false;
			this.studentListView.View = System.Windows.Forms.View.Details;
			this.studentListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListView_MouseClick);
			this.studentListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_MouseDoubleClick);
			// 
			// StudentID
			// 
			this.StudentID.Text = "ID";
			this.StudentID.Width = 30;
			// 
			// StudentSurname
			// 
			this.StudentSurname.Text = "Surname";
			// 
			// StudentName
			// 
			this.StudentName.Text = "Name";
			// 
			// StudentAge
			// 
			this.StudentAge.Text = "Age";
			this.StudentAge.Width = 40;
			// 
			// StudentMark
			// 
			this.StudentMark.Text = "Mark";
			// 
			// StudentCity
			// 
			this.StudentCity.Text = "City";
			// 
			// StudentStrit
			// 
			this.StudentStrit.Text = "Strit";
			// 
			// StudentHouseNumber
			// 
			this.StudentHouseNumber.Text = "House Number";
			this.StudentHouseNumber.Width = 100;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(880, 447);
			this.Controls.Add(this.studentListView);
			this.Controls.Add(this.teacherListView);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.showSelected);
			this.Controls.Add(this.CitycomboBox);
			this.Controls.Add(this.treeView1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.ComboBox CitycomboBox;
		private System.Windows.Forms.Button showSelected;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ListView teacherListView;
		private System.Windows.Forms.ListView studentListView;
		private System.Windows.Forms.ColumnHeader TeacherID;
		private System.Windows.Forms.ColumnHeader TeacherSurname;
		private System.Windows.Forms.ColumnHeader TeacherName;
		private System.Windows.Forms.ColumnHeader TeacherAge;
		private System.Windows.Forms.ColumnHeader TeacherCountStudents;
		private System.Windows.Forms.ColumnHeader TeacherCity;
		private System.Windows.Forms.ColumnHeader TeacherStrit;
		private System.Windows.Forms.ColumnHeader TeacherHouseNumber;
		private System.Windows.Forms.ColumnHeader StudentID;
		private System.Windows.Forms.ColumnHeader StudentSurname;
		private System.Windows.Forms.ColumnHeader StudentName;
		private System.Windows.Forms.ColumnHeader StudentAge;
		private System.Windows.Forms.ColumnHeader StudentMark;
		private System.Windows.Forms.ColumnHeader StudentCity;
		private System.Windows.Forms.ColumnHeader StudentStrit;
		private System.Windows.Forms.ColumnHeader StudentHouseNumber;
	}
}

