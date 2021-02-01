using Assignment2_EAD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Windows;
using Assignment2_EAD.Commands;

namespace Assignment2_EAD.ViewModels
{
   
    class AdminViewModel: BasicViewModel
    {
        public Admin myAdmin { get; set; }
        public DelegateCmnd cmd1 { get; set; }
        public DelegateCmnd cmd2 { get; set; }
        public DelegateCmnd cmd3 { get; set; }
    
        public AdminViewModel()
        {
            myAdmin = new Admin();

            cmd1 = new DelegateCmnd(login, canExecute);
      
            cmd2 = new DelegateCmnd(viewAllProducts, canExecute);
            cmd3 = new DelegateCmnd(logout, canExecute);

        }

        private void login(object obj)
        {
            myAdmin.LogIn();
        }
        private void logout(object obj)
        {
            myAdmin.LogOut();
        }
        
        private void viewAllProducts(object obj)
        {
            myAdmin.viewAllProducts();
        }
        public bool canExecute(object obj)
        {
            return true;
        }
    }
}

