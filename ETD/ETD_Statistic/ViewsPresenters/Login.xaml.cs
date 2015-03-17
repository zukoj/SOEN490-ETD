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
using System.Windows.Shapes;

namespace ETD_Statistic.ViewsPresenters
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (IsFormValid()) //if the form is valid, create an instance of mainwindow
            {
                MainWindow mw = new MainWindow();
                mw.Show();
                this.Close();
            }
        }

        private bool IsFormValid()
        {
            if (username.Text != "admin" && password.Text != "admin")
            {
                MessageBox.Show(ETD_Statistic.Properties.Resources.MessageBox_Notification_InvalidCredentials);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}