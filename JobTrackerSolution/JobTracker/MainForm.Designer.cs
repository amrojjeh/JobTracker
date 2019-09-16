namespace JobTrackerUI
{
	partial class MainForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.jobCB = new System.Windows.Forms.ComboBox();
			this.titleLbl = new System.Windows.Forms.Label();
			this.jobLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.logLst = new System.Windows.Forms.ListView();
			this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Start = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.End = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.availableDaysCB = new System.Windows.Forms.ComboBox();
			this.availableYearsCB = new System.Windows.Forms.ComboBox();
			this.availableMonthsCB = new System.Windows.Forms.ComboBox();
			this.clearFilterBtn = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.addLogBtn = new System.Windows.Forms.Button();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.modifyBtn = new System.Windows.Forms.Button();
			this.saveBtn = new System.Windows.Forms.Button();
			this.remarkTB = new System.Windows.Forms.RichTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.createJobTB = new System.Windows.Forms.TextBox();
			this.createJobB = new System.Windows.Forms.Button();
			this.removeJobBtn = new System.Windows.Forms.Button();
			this.optionsBtn = new System.Windows.Forms.Button();
			this.modifyJobBtn = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exportToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
			this.exportToolStripMenuItem.Text = "Export";
			this.exportToolStripMenuItem.Click += new System.EventHandler(this.ExportToolStripMenuItem_Click);
			// 
			// jobCB
			// 
			this.jobCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.jobCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.jobCB.FormattingEnabled = true;
			this.jobCB.Location = new System.Drawing.Point(346, 50);
			this.jobCB.Name = "jobCB";
			this.jobCB.Size = new System.Drawing.Size(174, 24);
			this.jobCB.TabIndex = 1;
			this.jobCB.SelectedIndexChanged += new System.EventHandler(this.JobCB_SelectedIndexChanged);
			// 
			// titleLbl
			// 
			this.titleLbl.AutoSize = true;
			this.titleLbl.Font = new System.Drawing.Font("Franklin Gothic Medium", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLbl.Location = new System.Drawing.Point(12, 34);
			this.titleLbl.Name = "titleLbl";
			this.titleLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.titleLbl.Size = new System.Drawing.Size(191, 41);
			this.titleLbl.TabIndex = 2;
			this.titleLbl.Text = "Job Tracker";
			this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// jobLabel
			// 
			this.jobLabel.AutoSize = true;
			this.jobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.jobLabel.Location = new System.Drawing.Point(227, 50);
			this.jobLabel.Name = "jobLabel";
			this.jobLabel.Size = new System.Drawing.Size(113, 25);
			this.jobLabel.TabIndex = 3;
			this.jobLabel.Text = "Select Job";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(148, 106);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 25);
			this.label1.TabIndex = 6;
			this.label1.Text = "Logs";
			// 
			// logLst
			// 
			this.logLst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.logLst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.Start,
            this.End,
            this.Duration});
			this.logLst.FullRowSelect = true;
			this.logLst.HideSelection = false;
			this.logLst.Location = new System.Drawing.Point(19, 134);
			this.logLst.MaximumSize = new System.Drawing.Size(1000, 1000);
			this.logLst.MinimumSize = new System.Drawing.Size(563, 270);
			this.logLst.Name = "logLst";
			this.logLst.Size = new System.Drawing.Size(563, 270);
			this.logLst.TabIndex = 7;
			this.logLst.UseCompatibleStateImageBehavior = false;
			this.logLst.View = System.Windows.Forms.View.Details;
			this.logLst.SelectedIndexChanged += new System.EventHandler(this.LogLst_SelectedIndexChanged);
			// 
			// Date
			// 
			this.Date.Text = "Date";
			this.Date.Width = 155;
			// 
			// Start
			// 
			this.Start.Text = "Start";
			this.Start.Width = 81;
			// 
			// End
			// 
			this.End.Text = "End";
			this.End.Width = 77;
			// 
			// Duration
			// 
			this.Duration.Text = "Duration";
			this.Duration.Width = 85;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(77, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 25);
			this.label2.TabIndex = 6;
			this.label2.Text = "Filter";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel1.Controls.Add(this.availableDaysCB);
			this.panel1.Controls.Add(this.availableYearsCB);
			this.panel1.Controls.Add(this.availableMonthsCB);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.clearFilterBtn);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(588, 109);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 176);
			this.panel1.TabIndex = 8;
			// 
			// availableDaysCB
			// 
			this.availableDaysCB.FormattingEnabled = true;
			this.availableDaysCB.Location = new System.Drawing.Point(76, 113);
			this.availableDaysCB.Name = "availableDaysCB";
			this.availableDaysCB.Size = new System.Drawing.Size(121, 21);
			this.availableDaysCB.TabIndex = 15;
			this.availableDaysCB.SelectedIndexChanged += new System.EventHandler(this.AvailableDaysCB_SelectedIndexChanged);
			// 
			// availableYearsCB
			// 
			this.availableYearsCB.FormattingEnabled = true;
			this.availableYearsCB.Location = new System.Drawing.Point(76, 50);
			this.availableYearsCB.Name = "availableYearsCB";
			this.availableYearsCB.Size = new System.Drawing.Size(121, 21);
			this.availableYearsCB.TabIndex = 14;
			this.availableYearsCB.SelectedIndexChanged += new System.EventHandler(this.AvailableYearsCB_SelectedIndexChanged);
			// 
			// availableMonthsCB
			// 
			this.availableMonthsCB.FormattingEnabled = true;
			this.availableMonthsCB.Location = new System.Drawing.Point(76, 83);
			this.availableMonthsCB.Name = "availableMonthsCB";
			this.availableMonthsCB.Size = new System.Drawing.Size(121, 21);
			this.availableMonthsCB.TabIndex = 13;
			this.availableMonthsCB.SelectedIndexChanged += new System.EventHandler(this.AvailableMonthsCB_SelectedIndexChanged);
			// 
			// clearFilterBtn
			// 
			this.clearFilterBtn.Location = new System.Drawing.Point(69, 150);
			this.clearFilterBtn.Name = "clearFilterBtn";
			this.clearFilterBtn.Size = new System.Drawing.Size(75, 23);
			this.clearFilterBtn.TabIndex = 9;
			this.clearFilterBtn.Text = "Clear";
			this.clearFilterBtn.UseVisualStyleBackColor = true;
			this.clearFilterBtn.Click += new System.EventHandler(this.ClearFilterBtn_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(22, 111);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 20);
			this.label5.TabIndex = 0;
			this.label5.Text = "Day";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(22, 81);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 20);
			this.label4.TabIndex = 0;
			this.label4.Text = "Month";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(22, 51);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Year";
			// 
			// addLogBtn
			// 
			this.addLogBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.addLogBtn.Location = new System.Drawing.Point(19, 415);
			this.addLogBtn.Name = "addLogBtn";
			this.addLogBtn.Size = new System.Drawing.Size(75, 23);
			this.addLogBtn.TabIndex = 9;
			this.addLogBtn.Text = "Add";
			this.addLogBtn.UseVisualStyleBackColor = true;
			this.addLogBtn.Click += new System.EventHandler(this.AddLogBtn_Click);
			// 
			// deleteBtn
			// 
			this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.deleteBtn.Location = new System.Drawing.Point(100, 415);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(75, 23);
			this.deleteBtn.TabIndex = 9;
			this.deleteBtn.Text = "Delete";
			this.deleteBtn.UseVisualStyleBackColor = true;
			this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
			// 
			// modifyBtn
			// 
			this.modifyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.modifyBtn.Location = new System.Drawing.Point(181, 415);
			this.modifyBtn.Name = "modifyBtn";
			this.modifyBtn.Size = new System.Drawing.Size(75, 23);
			this.modifyBtn.TabIndex = 9;
			this.modifyBtn.Text = "Modify";
			this.modifyBtn.UseVisualStyleBackColor = true;
			this.modifyBtn.Click += new System.EventHandler(this.ModifyBtn_Click);
			// 
			// saveBtn
			// 
			this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.saveBtn.Location = new System.Drawing.Point(262, 415);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(75, 23);
			this.saveBtn.TabIndex = 9;
			this.saveBtn.Text = "Save";
			this.saveBtn.UseVisualStyleBackColor = true;
			this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
			// 
			// remarkTB
			// 
			this.remarkTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.remarkTB.Location = new System.Drawing.Point(588, 320);
			this.remarkTB.Name = "remarkTB";
			this.remarkTB.Size = new System.Drawing.Size(200, 118);
			this.remarkTB.TabIndex = 10;
			this.remarkTB.Text = "";
			this.remarkTB.TextChanged += new System.EventHandler(this.RemarkTB_TextChanged);
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(643, 292);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(89, 25);
			this.label6.TabIndex = 6;
			this.label6.Text = "Remarks";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(227, 74);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(117, 25);
			this.label7.TabIndex = 3;
			this.label7.Text = "Create Job";
			// 
			// createJobTB
			// 
			this.createJobTB.Location = new System.Drawing.Point(346, 80);
			this.createJobTB.Name = "createJobTB";
			this.createJobTB.Size = new System.Drawing.Size(174, 20);
			this.createJobTB.TabIndex = 11;
			this.createJobTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CreateJobTB_KeyDown);
			// 
			// createJobB
			// 
			this.createJobB.Location = new System.Drawing.Point(526, 80);
			this.createJobB.Name = "createJobB";
			this.createJobB.Size = new System.Drawing.Size(75, 23);
			this.createJobB.TabIndex = 12;
			this.createJobB.Text = "Create";
			this.createJobB.UseVisualStyleBackColor = true;
			this.createJobB.Click += new System.EventHandler(this.CreateJobB_Click);
			// 
			// removeJobBtn
			// 
			this.removeJobBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.removeJobBtn.BackColor = System.Drawing.Color.Firebrick;
			this.removeJobBtn.ForeColor = System.Drawing.Color.Coral;
			this.removeJobBtn.Location = new System.Drawing.Point(505, 415);
			this.removeJobBtn.Name = "removeJobBtn";
			this.removeJobBtn.Size = new System.Drawing.Size(77, 23);
			this.removeJobBtn.TabIndex = 12;
			this.removeJobBtn.Text = "Remove Job";
			this.removeJobBtn.UseVisualStyleBackColor = false;
			this.removeJobBtn.Click += new System.EventHandler(this.RemoveJobBtn_Click);
			// 
			// optionsBtn
			// 
			this.optionsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.optionsBtn.Location = new System.Drawing.Point(343, 415);
			this.optionsBtn.Name = "optionsBtn";
			this.optionsBtn.Size = new System.Drawing.Size(75, 23);
			this.optionsBtn.TabIndex = 9;
			this.optionsBtn.Text = "Options";
			this.optionsBtn.UseVisualStyleBackColor = true;
			// 
			// modifyJobBtn
			// 
			this.modifyJobBtn.Location = new System.Drawing.Point(526, 52);
			this.modifyJobBtn.Name = "modifyJobBtn";
			this.modifyJobBtn.Size = new System.Drawing.Size(75, 23);
			this.modifyJobBtn.TabIndex = 12;
			this.modifyJobBtn.Text = "Modify Job";
			this.modifyJobBtn.UseVisualStyleBackColor = true;
			this.modifyJobBtn.Click += new System.EventHandler(this.CreateJobB_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.removeJobBtn);
			this.Controls.Add(this.modifyJobBtn);
			this.Controls.Add(this.createJobB);
			this.Controls.Add(this.createJobTB);
			this.Controls.Add(this.remarkTB);
			this.Controls.Add(this.optionsBtn);
			this.Controls.Add(this.saveBtn);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.modifyBtn);
			this.Controls.Add(this.deleteBtn);
			this.Controls.Add(this.addLogBtn);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.logLst);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.jobLabel);
			this.Controls.Add(this.titleLbl);
			this.Controls.Add(this.jobCB);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(816, 489);
			this.Name = "MainForm";
			this.Text = "Job Tracker";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ComboBox jobCB;
		private System.Windows.Forms.Label titleLbl;
		private System.Windows.Forms.Label jobLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView logLst;
		private System.Windows.Forms.ColumnHeader Date;
		private System.Windows.Forms.ColumnHeader Start;
		private System.Windows.Forms.ColumnHeader End;
		private System.Windows.Forms.ColumnHeader Duration;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
		private System.Windows.Forms.Button addLogBtn;
		private System.Windows.Forms.Button deleteBtn;
		private System.Windows.Forms.Button modifyBtn;
		private System.Windows.Forms.Button saveBtn;
		private System.Windows.Forms.RichTextBox remarkTB;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox createJobTB;
		private System.Windows.Forms.Button createJobB;
		private System.Windows.Forms.Button removeJobBtn;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.Button optionsBtn;
		private System.Windows.Forms.Button clearFilterBtn;
		private System.Windows.Forms.Button modifyJobBtn;
		private System.Windows.Forms.ComboBox availableDaysCB;
		private System.Windows.Forms.ComboBox availableYearsCB;
		private System.Windows.Forms.ComboBox availableMonthsCB;
	}
}

