﻿using JobTrackerLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace JobTrackerUI
{
	public partial class MainForm : Form
	{
		ComboBox.ObjectCollection availableYears;
		ComboBox.ObjectCollection availableMonths;
		ComboBox.ObjectCollection availableDays;

		Job selectedJob;

		User user = new User();
		// Should the user store the save directory?
		// I think so because if there were two seperate users using the same computer
		// they might want to save their files in different locations
		readonly string defaultSaveDirectory = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\JobTracker\\";

		public MainForm()
		{
			InitializeComponent();
			availableYears = availableYearsCB.Items;
			availableMonths = availableMonthsCB.Items;
			availableDays = availableDaysCB.Items;
			FormClosing += MainForm_FormClosing;
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!isSaved(defaultSaveDirectory, user.Username + ".yaml") && user.Jobs.Count != 0)
			{
				DialogResult result = MessageBox.Show("Do you want to save your file then quit?", "Unsaved",
					MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
				switch (result)
				{
					case DialogResult.Yes:
						DefaultSave();
						break;
					case DialogResult.No:
						break;
					default:
						e.Cancel = true;
						break;
				}
			}
		}

		private void AddDateToFilterPanel(DateTime date)
		{
			if (!availableYears.Contains(date.Year)) availableYears.Add(date.Year);
			if (!availableMonths.Contains(date.Month)) availableMonths.Add(date.Month);
			if (!availableDays.Contains(date.Day)) availableDays.Add(date.Day);
		}

		private void AddLogToList(Log log)
		{
			double duration = log.GetEstimatedDuration();
			string[] items = { log.Date.ToLongDateString(), FormattedTime.Get12Time(log.Start), FormattedTime.Get12Time(log.End), $"{duration} hour{(duration == 1 ? ' ' : 's')}" };
			ListViewItem item = new ListViewItem(items)
			{
				Tag = log
			};
			logLst.Items.Add(item);
			AddDateToFilterPanel(log.Date);
		}

		private void CreateJob()
		{
			string jobName = createJobTB.Text.Trim();
			if (jobName == "") return;
			Job job = new Job(jobName);
			if (user.Jobs.Contains(job))
			{
				MessageBox.Show("Job already exists", "Duplicate!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			user.Jobs.Add(job);
			createJobTB.Clear();
			jobCB.Items.Add(job);
			jobCB.SelectedItem = job; // Calls callback
		}

		private void CreateJobB_Click(object sender, System.EventArgs e)
		{
			CreateJob();
		}

		private void CreateJobTB_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) CreateJob();
		}

		private void AddLogBtn_Click(object sender, System.EventArgs e)
		{
			if (jobCB.Text == "")
			{
				MessageBox.Show("Must select job before you can add logs", "Error", MessageBoxButtons.OK);
				return;
			}
			NewLogForm form = new NewLogForm(selectedJob);
			form.ShowDialog();
			UpdateLogList();
			form.Dispose();
			DisableEnableButtons();
		}

		private void DisableEnableButtons() // Disable or enable buttons, depending on whether a job is selected
		{
			bool isJobSelected = jobCB.SelectedItem != null;
			bool isLogSelected = logLst.SelectedItems.Count != 0;
			bool isSingleLogSelected = logLst.SelectedItems.Count == 1;

			addLogBtn.Enabled = isJobSelected;
			deleteBtn.Enabled = isLogSelected;
			modifyBtn.Enabled = isSingleLogSelected;
			saveBtn.Enabled = isJobSelected;
			removeJobBtn.Enabled = isJobSelected;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			DisableEnableButtons();
			Size maxSize = new Size(int.MaxValue, int.MaxValue);
			logLst.MaximumSize = maxSize;
			if (user.Username != "") Display_Username();
		}

		private void FindAvailableDates(Job job)
		{
			availableYears.Clear();
			availableMonths.Clear();
			availableDays.Clear();

			job.ForEach(x => AddDateToFilterPanel(x.Date));
		}

		private void Display_Username()
		{
			Text = $"Job Tracker - {user.Username}";
		}

		private void JobCB_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectedJob = (Job)jobCB.SelectedItem;
			DisableEnableButtons();
			FindAvailableDates(selectedJob);
			UpdateLogList();
		}

		private void DeleteBtn_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in logLst.SelectedItems)
			{

				selectedJob.RemoveLog((Log)item.Tag);
			}
			UpdateLogList();
		}

		private void LogLst_SelectedIndexChanged(object sender, EventArgs e)
		{
			DisableEnableButtons();
			if (logLst.SelectedItems.Count != 0)
				remarkTB.Text = ((Log)logLst.SelectedItems[0].Tag).Remark;
		}

		private bool isSaved(string path, string file)
		{
			return UserToYaml.Yaml(user) == Loader.Load(Path.Combine(path, file));
		}

		private void SaveToYaml(string path)
		{
			Saver.Save(UserToYaml.Yaml(user), path);
		}

		private void Save(string path, string file)
		{
			Directory.CreateDirectory(path);
			SaveToYaml(Path.Combine(path, file));
		}

		private void FirstSave()
		{
			using (UsernameForm usernameForm = new UsernameForm())
			{
				usernameForm.ShowDialog();
				if (usernameForm.username != null)
					user.Username = usernameForm.username;
			}

			if (user.Username == "") return;

			if (IsThereDuplicateSave())
			{
				string message = $"Are you sure you want to replace your account {user.Username}? If no, then your current account will not save";
				DialogResult res = MessageBox.Show(message, "Account already exists",
					MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (res == DialogResult.No)
				{
					user.Username = "";
					return;
				}
			}

			Save(defaultSaveDirectory, user.Username + ".yaml");
			Display_Username();
		}

		private bool IsThereDuplicateSave()
		{
			if (!Directory.Exists(defaultSaveDirectory)) return false;
			foreach (string file in Directory.GetFiles(defaultSaveDirectory))
				if (Path.GetFileName(file) == user.Username + ".yaml")
					return true;
			return false;
		}

		private void DefaultSave()
		{
			string path = defaultSaveDirectory;
			if (user.Username.Trim() == "")
			{
				FirstSave();
				return;
			}
			string file = $"{user.Username}.yaml";
			Save(path, file);
		}

		private void Export()
		{
			string Fullpath;
			using (SaveFileDialog saveFile = new SaveFileDialog()
			{
				AddExtension = true,
				Filter = "Yaml files (*.yaml)|*.yaml"
			})
			{
				saveFile.ShowDialog();
				Fullpath = saveFile.FileName;
			}
			if (Fullpath.Trim() != "")
			{
				string path = Path.GetDirectoryName(Fullpath);
				string file = Path.GetFileName(Fullpath);

				Save(path, file);
			}
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			DefaultSave();
		}

		private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DefaultSave();
		}

		private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Export();
		}

		private void OpenToolStripMenuItem_Click(object sender, EventArgs e) // TODO
		{
			OpenFile();
		}

		private void OpenFile()
		{
			string fileName;
			using (OpenFileDialog openFile = new OpenFileDialog()
			{
				Filter = "Yaml files (*.yaml)|*.yaml",
				InitialDirectory = defaultSaveDirectory
			})
			{
				openFile.ShowDialog();
				fileName = openFile.FileName;
			}
			if (fileName.Trim() != "")
				user = YamlToUser.User(Loader.Load(fileName));
			UpdateUser();
		}

		private void UpdateUser()
		{
			UpdateJobs();
			UpdateLogList();
			Display_Username();
		}

		private void UpdateJobs()
		{
			jobCB.Items.Clear();
			if (user == null || user.Jobs.Count == 0) return;
			Job[] jobs = new Job[user.Jobs.Count];
			user.Jobs.CopyTo(jobs);
			jobCB.Items.AddRange(jobs);
			jobCB.SelectedIndex = 0;
		}

		public void UpdateLogList()
		{
			logLst.Items.Clear();
			if (jobCB.SelectedItem == null) return;
			if (availableYearsCB.SelectedIndex != -1 || availableMonthsCB.SelectedIndex != -1 || availableDaysCB.SelectedIndex != -1)
			{
				LogFilter.SetDate((int?)availableYearsCB.SelectedItem, (int?)availableMonthsCB.SelectedItem, (int?)availableDaysCB.SelectedItem);
				LogFilter.FilterLogs(selectedJob).ForEach(x => AddLogToList(x));
			}
			else selectedJob.ForEach((log) => AddLogToList(log));
		}

		private void RemoveJobBtn_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to remove the currently selected job?",
				"Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.No) return;
			user.Jobs.Remove(selectedJob);
			selectedJob = null;
			UpdateUser();
		}

		private void ModifyBtn_Click(object sender, EventArgs e)
		{
			selectedJob.RemoveLog((Log)logLst.SelectedItems[0].Tag);
			NewLogForm newLog = new NewLogForm(selectedJob, (Log)logLst.SelectedItems[0].Tag);
			newLog.ShowDialog();
			newLog.Dispose();
			UpdateLogList();
		}

		private void RemarkTB_TextChanged(object sender, EventArgs e)
		{
			if (logLst.SelectedItems.Count == 0) return;
			((Log)logLst.SelectedItems[0].Tag).Remark = remarkTB.Text;
		}

		private void AvailableYearsCB_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateLogList();
		}

		private void AvailableMonthsCB_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateLogList();
		}

		private void AvailableDaysCB_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateLogList();
		}

		private void ClearFilterBtn_Click(object sender, EventArgs e)
		{
			availableDaysCB.SelectedIndex = -1;
			availableMonthsCB.SelectedIndex = -1;
			availableYearsCB.SelectedIndex = -1;
		}
	}
}
