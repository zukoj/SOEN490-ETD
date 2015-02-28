﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ETD.ViewsPresenters.InterventionsSection.InterventionForm.TimersInterventionForm;
using ETD.ViewsPresenters.InterventionsSection.InterventionForm.DetailsInterventionForm;
using ETD.ViewsPresenters.InterventionsSection.InterventionForm.ResourcesInterventionForm;
using ETD.ViewsPresenters.InterventionsSection.InterventionForm.ABCInterventionForm;
using ETD.ViewsPresenters.InterventionsSection.InterventionForm.AdditionalInfoInterventionForm;
using ETD.ViewsPresenters.InterventionsSection.InterventionForm.EndInterventionForm;
using ETD.Models.Objects;
using System.Windows.Threading;
using ETD.Models.ArchitecturalObjects;

namespace ETD.ViewsPresenters.InterventionsSection.InterventionForm
{
    /// <summary>
    /// Interaction logic for InterventionForm.xaml
    /// </summary>
    public partial class InterventionFormPage : Page, Observer
    {
		private InterventionSectionPage interventionSection;
		private Intervention intervention;
		private TimersInterventionFormPage timersPage;
		Frame timersFrame;
		private DetailsInterventionFormPage detailsPage;
		Frame detailsFrame;
		private ResourcesInterventionFormPage resourcesPage;
		Frame resourcesFrame;
		private ABCInterventionFormPage abcPage;
		Frame abcFrame;
		private AdditionalInfoInterventionFormPage additionalInfoPage;
		Frame additionalInfoFrame;
		private EndInterventionFormPage endPage;
		Frame endFrame;

		private DispatcherTimer dispatcherTimer = new DispatcherTimer();

		public InterventionFormPage(InterventionSectionPage interventionSection, Intervention intervention)
        {
            InitializeComponent();
			this.interventionSection = interventionSection;

			this.intervention = intervention;
			setInterventionNumber(intervention.getInterventionNumber());
			//Set the intervention type RED if it is of code 1

			dispatcherTimer.Tick += new EventHandler(PersistencyUpdate);
			dispatcherTimer.Interval += new TimeSpan(0, 0, 30);
			dispatcherTimer.Start();

			BuildComponents();
            
            details.Focus();

			intervention.RegisterInstanceObserver(this);
		}

		private void BuildComponents()
		{
			timersPage = new TimersInterventionFormPage(this, intervention);
			detailsPage = new DetailsInterventionFormPage(this, intervention);
			resourcesPage = new ResourcesInterventionFormPage(this, intervention);
			abcPage = new ABCInterventionFormPage(this, intervention.getABC());
			additionalInfoPage = new AdditionalInfoInterventionFormPage(this, intervention);
			endPage = new EndInterventionFormPage(this, intervention);

			timersFrame = new Frame();
			timersFrame.Content = timersPage;
			timers.Content = timersFrame;

			detailsFrame = new Frame();
			detailsFrame.Content = detailsPage;
			details.Content = detailsFrame;

			resourcesFrame = new Frame();
			resourcesFrame.Content = resourcesPage;
			resources.Content = resourcesFrame;

			abcFrame = new Frame();
			abcFrame.Content = abcPage;
			abc.Content = abcFrame;

			additionalInfoFrame = new Frame();
			additionalInfoFrame.Content = additionalInfoPage;
			additionalInfo.Content = additionalInfoFrame;

			endFrame = new Frame();
			endFrame.Content = endPage;
			end.Content = endFrame;

			if (intervention.IsCompleted())
			{
				DisableForms();
			}
		}

		public void Update()
		{
			BuildComponents();
		}

		public void setInterventionNumber(int interventionNum)
		{
			interventionNumber.Text = "" + interventionNum;
		}

		public int getInterventionNumber()
		{
			return intervention.getInterventionNumber();
		}

		public void setComplaint(String complaint)
		{
			interventionType.Text = complaint;
		}

		public void setPriority(String priority)
		{
			if(priority.Equals("1"))
			{
				interventionType.Foreground = new SolidColorBrush(Colors.Red);
			}
			else
			{
				interventionType.Foreground = new SolidColorBrush(Colors.Black);
			}
		}

		public void setTeam(String team)
		{
			teamName.Text = team;
		}

		//Runs once per minute - Registers all changes in the form to the intervention object
		public void PersistencyUpdate(object sender, EventArgs e)
		{
            
			detailsPage.PersistencyUpdate();
			//resourcesPage.PersistencyUpdate();
			//abcPage.PersistencyUpdate();
			//additionalInfoPage.PersistencyUpdate();
			endPage.PersistencyUpdate();
             
		}

		//Hiding intervention form after completion
		public void CompleteIntervention(int offset)
		{
			//Stopping timer
			if(timersPage.StopOverallTimer(offset))
			{
				interventionSection.CompleteIntervention(getInterventionNumber());

                DisableForms();
			}
		}

		public void CreateOverallTimer(int offset)
		{
			timersPage.CreateOverallTimer(offset);
		}

		public void CreateTimer(int position, String team, String resource, int offset)
		{
			timersPage.CreateTimer(position, team, resource, offset);
		}

		public void StopTimer(int position, int offset)
		{
			timersPage.StopTimer(position, offset);
		}

        public void RenameTimer(int position, String team, String resource)
        {
            timersPage.RenameTimer(position, team, resource);
        }
		
        public bool IsTimerRunning(int position)
        {
            return timersPage.IsRunning(position);
        }

        public void CloneTimer(int position, String team, String resource, int offset, int original)
        {
            timersPage.CloneTimer(position, team, resource, offset, original);
        }

		internal void AddResource(String teamName)
		{
			resources.Focus();
			resourcesPage.AddResources(teamName);
		}

		internal void ReportArrival(String teamName)
		{
			timers.Focus();
			resourcesPage.ReportArrival(teamName);
		}

        internal void ReportArrived(int rowNumber)
        {
            interventionSection.ReportArrived(this, rowNumber);
        }
        
		public static void setInterventionDeadline(int deadline)
		{
			TimersInterventionFormPage.setInterventionDeadline(deadline);
		}

		public static void setMovingDeadline(int deadline)
		{
			TimersInterventionFormPage.setMovingDeadline(deadline);
		}

        private void DisableForms()
        {
            timersFrame.IsEnabled = false;
            detailsFrame.IsEnabled = false;
            resourcesFrame.IsEnabled = false;
            abcFrame.IsEnabled = false;
            additionalInfoFrame.IsEnabled = false;
            endFrame.IsEnabled = false;
        }
    }
}
