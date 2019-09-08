namespace JobTrackerUI
{
	partial class UsernameForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.UsernameTB = new System.Windows.Forms.TextBox();
			this.saveBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(59, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(362, 35);
			this.label1.TabIndex = 0;
			this.label1.Text = "This is your first time saving";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(106, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(276, 35);
			this.label2.TabIndex = 1;
			this.label2.Text = "Enter your username";
			// 
			// UsernameTB
			// 
			this.UsernameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UsernameTB.Location = new System.Drawing.Point(65, 103);
			this.UsernameTB.Name = "UsernameTB";
			this.UsernameTB.Size = new System.Drawing.Size(250, 30);
			this.UsernameTB.TabIndex = 2;
			this.UsernameTB.Text = "Username";
			this.UsernameTB.TextChanged += new System.EventHandler(this.UsernameTB_TextChanged);
			this.UsernameTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsernameTB_KeyDown);
			// 
			// saveBtn
			// 
			this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveBtn.Location = new System.Drawing.Point(321, 99);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(171, 38);
			this.saveBtn.TabIndex = 3;
			this.saveBtn.Text = "Finish And Save";
			this.saveBtn.UseVisualStyleBackColor = true;
			this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
			// 
			// UsernameForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(519, 170);
			this.Controls.Add(this.saveBtn);
			this.Controls.Add(this.UsernameTB);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "UsernameForm";
			this.Text = "Username";
			this.Load += new System.EventHandler(this.UsernameForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox UsernameTB;
		private System.Windows.Forms.Button saveBtn;
	}
}