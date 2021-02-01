using Assignment2_EAD.Commands;
using Assignment2_EAD.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_EAD.ViewModels
{
    class CustomerViewModel:BasicViewModel
    {
        public Customer customer { get; set; }
        public DelegateCmnd cmd1 { get; set; }
        public DelegateCmnd cmd2 { get; set; }


        public CustomerViewModel()
        {
            customer = new Customer();
            cmd1 = new DelegateCmnd(login, canExecute);
            cmd2 = new DelegateCmnd(signup, canExecute);


        }

        private void signup(object obj)
        {
            customer.SignUp(customer);
        }

        private bool canExecute(object obj)
        {
            return true;
        }

        private void login(object obj)
        {
            customer.LogIn(customer);
        }
    }
}
