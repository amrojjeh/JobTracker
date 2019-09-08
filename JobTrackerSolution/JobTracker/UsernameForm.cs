using System;
using System.Windows.Forms;

namespace JobTrackerUI
{
	public partial class UsernameForm : Form
	{
		public string username;

		public UsernameForm()
		{
			InitializeComponent();
		}

		private void UsernameForm_Load(object sender, EventArgs e)
		{
			UsernameTB.Text = Environment.UserName;
		}

		private void Finish()
		{
			username = UsernameTB.Text.Trim();
			if (username == "")
				MessageBox.Show("Cannot have a blank username!", "Blank username",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
				Close();
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			Finish();
		}

		private void UsernameTB_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				Finish();
			}
		}

		private void UsernameTB_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
