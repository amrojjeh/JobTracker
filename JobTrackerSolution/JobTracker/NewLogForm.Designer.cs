namespace JobTrackerUI
{
	partial class NewLogForm
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
			this.titleLabel = new System.Windows.Forms.Label();
			this.jobLBL = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.durationLbl = new System.Windows.Forms.Label();
			this.submitBtn = new System.Windows.Forms.Button();
			this.dateDTP = new System.Windows.Forms.DateTimePicker();
			this.startTimeDTP = new System.Windows.Forms.DateTimePicker();
			this.endTimeDTP = new System.Windows.Forms.DateTimePicker();
			this.errorLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// titleLabel
			// 
			this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.titleLabel.AutoSize = true;
			this.titleLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLabel.Location = new System.Drawing.Point(12, 9);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.titleLabel.Size = new System.Drawing.Size(191, 41);
			this.titleLabel.TabIndex = 3;
			this.titleLabel.Text = "Job Tracker";
			this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// jobLBL
			// 
			this.jobLBL.AutoSize = true;
			this.jobLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.jobLBL.Location = new System.Drawing.Point(14, 49);
			this.jobLBL.Name = "jobLBL";
			this.jobLBL.Size = new System.Drawing.Size(161, 25);
			this.jobLBL.TabIndex = 4;
			this.jobLBL.Text = "New Log For Job";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(14, 95);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 25);
			this.label7.TabIndex = 5;
			this.label7.Text = "Date";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(14, 120);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 25);
			this.label1.TabIndex = 5;
			this.label1.Text = "Start Time";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(14, 146);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 25);
			this.label2.TabIndex = 5;
			this.label2.Text = "End Time";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(186, 191);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 25);
			this.label3.TabIndex = 5;
			this.label3.Text = "Duration:";
			// 
			// durationLbl
			// 
			this.durationLbl.AutoSize = true;
			this.durationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.durationLbl.Location = new System.Drawing.Point(285, 191);
			this.durationLbl.Name = "durationLbl";
			this.durationLbl.Size = new System.Drawing.Size(237, 25);
			this.durationLbl.TabIndex = 5;
			this.durationLbl.Text = "2 hours and 30 minutes";
			// 
			// submitBtn
			// 
			this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.submitBtn.Location = new System.Drawing.Point(20, 176);
			this.submitBtn.Name = "submitBtn";
			this.submitBtn.Size = new System.Drawing.Size(160, 38);
			this.submitBtn.TabIndex = 7;
			this.submitBtn.Text = "Submit";
			this.submitBtn.UseVisualStyleBackColor = true;
			this.submitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
			// 
			// dateDTP
			// 
			this.dateDTP.CustomFormat = "";
			this.dateDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateDTP.Location = new System.Drawing.Point(77, 90);
			this.dateDTP.Name = "dateDTP";
			this.dateDTP.Size = new System.Drawing.Size(290, 27);
			this.dateDTP.TabIndex = 8;
			this.dateDTP.ValueChanged += new System.EventHandler(this.DateDTP_ValueChanged);
			// 
			// startTimeDTP
			// 
			this.startTimeDTP.CustomFormat = "hh:mm tt";
			this.startTimeDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startTimeDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.startTimeDTP.Location = new System.Drawing.Point(123, 118);
			this.startTimeDTP.Name = "startTimeDTP";
			this.startTimeDTP.ShowUpDown = true;
			this.startTimeDTP.Size = new System.Drawing.Size(105, 27);
			this.startTimeDTP.TabIndex = 9;
			this.startTimeDTP.ValueChanged += new System.EventHandler(this.StartTimeDTP_ValueChanged);
			// 
			// endTimeDTP
			// 
			this.endTimeDTP.CustomFormat = "hh:mm tt";
			this.endTimeDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.endTimeDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.endTimeDTP.Location = new System.Drawing.Point(123, 146);
			this.endTimeDTP.Name = "endTimeDTP";
			this.endTimeDTP.ShowUpDown = true;
			this.endTimeDTP.Size = new System.Drawing.Size(105, 27);
			this.endTimeDTP.TabIndex = 9;
			this.endTimeDTP.ValueChanged += new System.EventHandler(this.EndTimeDTP_ValueChanged);
			// 
			// errorLbl
			// 
			this.errorLbl.AutoSize = true;
			this.errorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.errorLbl.ForeColor = System.Drawing.Color.Maroon;
			this.errorLbl.Location = new System.Drawing.Point(234, 126);
			this.errorLbl.Name = "errorLbl";
			this.errorLbl.Size = new System.Drawing.Size(292, 17);
			this.errorLbl.TabIndex = 10;
			this.errorLbl.Text = "* Start time and end time cannot be the same";
			// 
			// NewLogForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(548, 225);
			this.Controls.Add(this.errorLbl);
			this.Controls.Add(this.endTimeDTP);
			this.Controls.Add(this.startTimeDTP);
			this.Controls.Add(this.dateDTP);
			this.Controls.Add(this.submitBtn);
			this.Controls.Add(this.durationLbl);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.jobLBL);
			this.Controls.Add(this.titleLabel);
			this.Name = "NewLogForm";
			this.Text = "New Log";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewLogForm_FormClosing);
			this.Load += new System.EventHandler(this.NewLogForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Label jobLBL;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label durationLbl;
		private System.Windows.Forms.Button submitBtn;
		private System.Windows.Forms.DateTimePicker dateDTP;
		private System.Windows.Forms.DateTimePicker startTimeDTP;
		private System.Windows.Forms.DateTimePicker endTimeDTP;
		private System.Windows.Forms.Label errorLbl;
	}
}