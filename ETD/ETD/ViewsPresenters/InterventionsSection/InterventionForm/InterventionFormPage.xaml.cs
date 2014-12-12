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
using ETD.ViewsPresenters.InterventionsSection;
using ETD.ViewsPresenters.InterventionsSection.InterventionForm.TimersInterventionForm;
using ETD.ViewsPresenters.InterventionsSection.InterventionForm.DetailsInterventionForm;
using ETD.ViewsPresenters.InterventionsSection.InterventionForm.ResourcesInterventionForm;
using ETD.ViewsPresenters.InterventionsSection.InterventionForm.ABCInterventionForm;
using ETD.ViewsPresenters.InterventionsSection.InterventionForm.AdditionalInfoInterventionForm;
using ETD.ViewsPresenters.InterventionsSection.InterventionForm.EndInterventionForm;
using ETD.Models;
using System.Windows.Threading;

namespace ETD.ViewsPresenters.InterventionsSection.InterventionForm
{
    /// <summary>
    /// Interaction logic for InterventionForm.xaml
    /// </summary>
    public partial class InterventionFormPage : Page
    {
		private InterventionSectionPage interventionSection;
		private Intervention intervention;
		private TimersInterventionFormPage timersPage;
		private DetailsInterventionFormPage detailsPage;
		private ResourcesInterventionFormPage resourcesPage;
		private ABCInterventionFormPage abcPage;
		private AdditionalInfoInterventionFormPage additionalInfoPage;
		private EndInterventionFormPage endPage;

		private DispatcherTimer dispatcherTimer = new DispatcherTimer();

		public InterventionFormPage(InterventionSectionPage interventionSection, Intervention intervention)
        {
            InitializeComponent();
			this.interventionSection = interventionSection;

			this.intervention = intervention;
			setInterventionNumber(intervention.getInterventionNumber());
			//Set the intervention type RED if it is of code 1

			dispatcherTimer.Tick += new EventHandler(PersistencyUpdate);
			dispatcherTimer.Interval += new TimeSpan(0, 1, 0);
			dispatcherTimer.Start();

			timersPage = new TimersInterventionFormPage(this);
			detailsPage = new DetailsInterventionFormPage(this, intervention);
			resourcesPage = new ResourcesInterventionFormPage(this, intervention);
			abcPage = new ABCInterventionFormPage(this, intervention);
			additionalInfoPage = new AdditionalInfoInterventionFormPage(this, intervention);
			endPage = new EndInterventionFormPage(this, intervention);

			Frame timersFrame = new Frame();
			timersFrame.Content = timersPage;
			timers.Content = timersFrame;

			Frame detailsFrame = new Frame();
			detailsFrame.Content = detailsPage;
			details.Content = detailsFrame;

			Frame resourcesFrame = new Frame();
			resourcesFrame.Content = resourcesPage;
			resources.Content = resourcesFrame;

			Frame abcFrame = new Frame();
			abcFrame.Content = abcPage;
			abc.Content = abcFrame;

			Frame additionalInfoFrame = new Frame();
			additionalInfoFrame.Content = additionalInfoPage;
			additionalInfo.Content = additionalInfoFrame;

			Frame endFrame = new Frame();
			endFrame.Content = endPage;
			end.Content = endFrame;
		}

		public void setInterventionNumber(int interventionNum)
		{
			interventionNumber.Text = "" + interventionNum;
		}

		public int getInterventionNumber()
		{
			return intervention.getInterventionNumber();
		}

		//Runs once per minute - Registers all changes in the form to the intervention object
		public void PersistencyUpdate(object sender, EventArgs e)
		{
			detailsPage.PersistencyUpdate();
			resourcesPage.PersistencyUpdate();
		}

		//Hiding intervention form after completion
		public void HideInterventionForm(int offset)
		{
			//Stopping timer
			if(timersPage.StopOverallTimer(offset))
			{
			interventionSection.HideInterventionForm(getInterventionNumber());
			}
		}

		public void CreateTimer(int position, String team, String resource, int offset)
		{
			timersPage.CreateTimer(position, team, resource, offset);
		}

		public void StopTimer(int position, int offset)
		{
			timersPage.StopTimer(position, offset);
		}
    }
}
