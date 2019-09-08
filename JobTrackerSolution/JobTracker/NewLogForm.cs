using JobTrackerLibrary;
using System.Windows.Forms;
using System;

namespace JobTrackerUI
{
	public partial class NewLogForm : Form
	{
		readonly Job currentJob;
		readonly Log log;
		bool submitted = false;

		public NewLogForm(Job job)
		{
			currentJob = job;
			InitializeComponent();
		}

		public NewLogForm(Job job, Log log)
		{
			currentJob = job;
			this.log = log;
			InitializeComponent();
		}

		private int CalculuateDurationInMinutes()
		{
			int startTimeMinutes = startTimeDTP.Value.Hour * 60 + startTimeDTP.Value.Minute;
			int endTimeMinutes = endTimeDTP.Value.Hour * 60 + endTimeDTP.Value.Minute;
			return endTimeMinutes - startTimeMinutes;
		}

		private string DurationToString()
		{
			int inProperMinutes = CalculuateDurationInMinutes();
			int hours = inProperMinutes / 60;
			int minutes = inProperMinutes - hours * 60;
			return $"{hours} hours and {minutes} minutes";
		}

		private void NewLogForm_Load(object sender, System.EventArgs e)
		{
			string newOrChange = log == null ? "New" : "Change";
			jobLBL.Text = $"{newOrChange} Log for {currentJob.JobName}";
			Text = $"{newOrChange} Log";
			if (newOrChange == "Change")
			{
				dateDTP.Value = new DateTime(log.Date.Year, log.Date.Month, log.Date.Day);
				startTimeDTP.Value = new DateTime(startTimeDTP.Value.Year,
					startTimeDTP.Value.Month, startTimeDTP.Value.Day,
					log.Start.Hour, log.Start.Minute, 0);
				endTimeDTP.Value = new DateTime(endTimeDTP.Value.Year,
					endTimeDTP.Value.Month, endTimeDTP.Value.Day,
					log.End.Hour, log.End.Minute, 0);
			}
			durationLbl.Text = DurationToString();
			FindAndDisplayErrors();
		}

		private void SubmitBtn_Click(object sender, System.EventArgs e)
		{
			Time start = new Time(startTimeDTP.Value.Hour, startTimeDTP.Value.Minute);
			Time end = new Time(endTimeDTP.Value.Hour, endTimeDTP.Value.Minute);
			Log log = new Log(dateDTP.Value.Year, dateDTP.Value.Month, dateDTP.Value.Day, start, end);
			currentJob.AddLog(log);
			submitted = true;
			this.Close();
		}

		private void StartTimeDTP_ValueChanged(object sender, System.EventArgs e)
		{
			durationLbl.Text = DurationToString();
			FindAndDisplayErrors();
		}

		private void EndTimeDTP_ValueChanged(object sender, System.EventArgs e)
		{
			durationLbl.Text = DurationToString();
			FindAndDisplayErrors();
		}

		private void FindAndDisplayErrors()
		{
			Time start = new Time(startTimeDTP.Value.Hour, startTimeDTP.Value.Minute);
			Time end = new Time(endTimeDTP.Value.Hour, endTimeDTP.Value.Minute);
			string errors = "";
			bool enableButton = false;
			if (Log.StartingTimeSameAsEndingTimeException(start, end))
			{
				errors += "* Start time and end time cannot be the same!\n";
			}

			else if (Log.StartTimeHigherThanEndTimeException(start, end))
			{
				errors += "* Start time cannot be higher than end time!\n";
			}

			else if (currentJob.OverlappingLogException(new Log(dateDTP.Value.Year, dateDTP.Value.Month, dateDTP.Value.Day, start, end)))
			{
				errors += "* Log cannot overlap with another log!\n";
			}
			else
			{
				enableButton = true;
			}
			submitBtn.Enabled = enableButton;
			errorLbl.Text = errors;
		}

		private void DateDTP_ValueChanged(object sender, EventArgs e)
		{
			FindAndDisplayErrors();
		}

		private void NewLogForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (log != null && !submitted)
				currentJob.AddLog(log);
		}
	}
}
