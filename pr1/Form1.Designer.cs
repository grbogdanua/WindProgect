
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
			this.TeacherdataGridView = new System.Windows.Forms.DataGridView();
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
			this.StudentdataGridView = new System.Windows.Forms.DataGridView();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.TeacherdataGridView)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.StudentdataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// TeacherdataGridView
			// 
			this.TeacherdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TeacherdataGridView.Location = new System.Drawing.Point(363, 48);
			this.TeacherdataGridView.Name = "TeacherdataGridView";
			this.TeacherdataGridView.Size = new System.Drawing.Size(469, 182);
			this.TeacherdataGridView.TabIndex = 0;
			this.TeacherdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeacherdataGridView_CellClick);
			this.TeacherdataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeacherdataGridView_CellDoubleClick);
			// 
			// treeView1
			// 
			this.treeView1.CheckBoxes = true;
			this.treeView1.Location = new System.Drawing.Point(12, 48);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(170, 390);
			this.treeView1.TabIndex = 2;
			// 
			// CitycomboBox
			// 
			this.CitycomboBox.FormattingEnabled = true;
			this.CitycomboBox.Location = new System.Drawing.Point(188, 48);
			this.CitycomboBox.Name = "CitycomboBox";
			this.CitycomboBox.Size = new System.Drawing.Size(169, 21);
			this.CitycomboBox.TabIndex = 3;
			this.CitycomboBox.SelectedIndexChanged += new System.EventHandler(this.CitycomboBox_SelectedIndexChanged_1);
			// 
			// showSelected
			// 
			this.showSelected.Location = new System.Drawing.Point(188, 94);
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
			this.menuStrip1.Size = new System.Drawing.Size(844, 24);
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
			// StudentdataGridView
			// 
			this.StudentdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.StudentdataGridView.Location = new System.Drawing.Point(363, 237);
			this.StudentdataGridView.Name = "StudentdataGridView";
			this.StudentdataGridView.Size = new System.Drawing.Size(469, 201);
			this.StudentdataGridView.TabIndex = 8;
			this.StudentdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentdataGridView_CellClick);
			this.StudentdataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentdataGridView_CellDoubleClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(189, 214);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(168, 224);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(844, 450);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.StudentdataGridView);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.showSelected);
			this.Controls.Add(this.CitycomboBox);
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.TeacherdataGridView);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.TeacherdataGridView)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.StudentdataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView TeacherdataGridView;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.ComboBox CitycomboBox;
		private System.Windows.Forms.Button showSelected;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
		private System.Windows.Forms.DataGridView StudentdataGridView;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

