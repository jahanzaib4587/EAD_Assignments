﻿using Assignment2_EAD.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment2_EAD.Views
{
    /// <summary>
    /// Interaction logic for AdminUserView.xaml
    /// </summary>
    public partial class AdminUserView : UserControl
    {
        public AdminUserView()
        {
            InitializeComponent();
           
                 this.DataContext = new FirstViewModel();
        }
    }
}
