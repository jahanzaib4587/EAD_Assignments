using Assignment2_EAD.Commands;
using Assignment2_EAD.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
namespace Assignment2_EAD.ViewModels
{
    class FirstViewModel:BasicViewModel
    {
        public DelegateCmnd cmd1 { get; set; }
        public DelegateCmnd cmd2 { get; set; }

        public FirstViewModel()
        {

            cmd1 = new DelegateCmnd(SelectedVal1, canExecute);

        }

        private void SelectedVal1(object obj)
        {
            if ((obj as string).Equals("Admin"))
            {

                AdminView a = new AdminView();
                a.Show();


            }
            else if ((obj as string).Equals("Customer"))
            {


               UserView u = new UserView();
                u.Show();


            }
        }
       
        public bool canExecute(object obj)
        {
            return true;
        }
    }
}
