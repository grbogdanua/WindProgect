
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
			this.TeacherdataGridView = new System.Windows.Forms.DataGridView();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.CitycomboBox = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.StudentdataGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.TeacherdataGridView)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.StudentdataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// TeacherdataGridView
			// 
			this.TeacherdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TeacherdataGridView.Location = new System.Drawing.Point(485, 48);
			this.TeacherdataGridView.Name = "TeacherdataGridView";
			this.TeacherdataGridView.Size = new System.Drawing.Size(471, 182);
			this.TeacherdataGridView.TabIndex = 0;
			// 
			// treeView1
			// 
			this.treeView1.CheckBoxes = true;
			this.treeView1.Location = new System.Drawing.Point(12, 48);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(170, 390);
			this.treeView1.TabIndex = 2;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// CitycomboBox
			// 
			this.CitycomboBox.FormattingEnabled = true;
			this.CitycomboBox.Location = new System.Drawing.Point(254, 48);
			this.CitycomboBox.Name = "CitycomboBox";
			this.CitycomboBox.Size = new System.Drawing.Size(169, 21);
			this.CitycomboBox.TabIndex = 3;
			this.CitycomboBox.SelectedIndexChanged += new System.EventHandler(this.CitycomboBox_SelectedIndexChanged_1);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(306, 122);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(982, 24);
			this.menuStrip1.TabIndex = 7;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teacherToolStripMenuItem,
            this.studentToolStripMenuItem});
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
			this.newToolStripMenuItem.Text = "new";
			// 
			// teacherToolStripMenuItem
			// 
			this.teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
			this.teacherToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.teacherToolStripMenuItem.Text = "teacher";
			this.teacherToolStripMenuItem.Click += new System.EventHandler(this.teacherToolStripMenuItem_Click);
			// 
			// studentToolStripMenuItem
			// 
			this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
			this.studentToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.studentToolStripMenuItem.Text = "student";
			this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
			// 
			// StudentdataGridView
			// 
			this.StudentdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.StudentdataGridView.Location = new System.Drawing.Point(485, 237);
			this.StudentdataGridView.Name = "StudentdataGridView";
			this.StudentdataGridView.Size = new System.Drawing.Size(471, 201);
			this.StudentdataGridView.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(982, 450);
			this.Controls.Add(this.StudentdataGridView);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.button1);
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
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView TeacherdataGridView;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.ComboBox CitycomboBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
		private System.Windows.Forms.DataGridView StudentdataGridView;
	}
}

