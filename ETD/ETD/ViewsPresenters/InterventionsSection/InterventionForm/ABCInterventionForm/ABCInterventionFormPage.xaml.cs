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

namespace ETD.ViewsPresenters.InterventionsSection.InterventionForm.ABCInterventionForm
{
	/// <summary>
	/// Interaction logic for ABCInterventionFormPage.xaml
	/// </summary>
	public partial class ABCInterventionFormPage : Page
	{
		private InterventionFormPage interventionForm;

		public ABCInterventionFormPage(InterventionFormPage interventionForm)
		{
			InitializeComponent();
			this.interventionForm = interventionForm;
		}
	}
}