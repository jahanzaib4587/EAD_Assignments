using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;

namespace Task1
{
    class viewModel: INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public Submit submit { get; set; }
        public Cancel cancelVar { get; set; }

        public string passwordMatch;
        public viewModel()
        {
            submit = new Submit(this);
            cancelVar = new Cancel(this);
        }
        public string passwordMatched
        {
            get
            {
                return passwordMatch;
            }
            set
            {
                passwordMatch = value;
                isMatched("Match");

            }
        }
        public bool doexecute(object[] val)
        {
            string name = val[0] as string;
            string oldPassword = val[1] as string;
            string newPassword = val[2] as string;
            string confirmPassword = val[3] as string;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                return false;
            }
            else if (newPassword.Equals(confirmPassword))
            {
                passwordMatched = "Matched";
                return true;
            }
            else
            {
                passwordMatched = "No Matched";
                return false;

            }

        }
        public void isMatched(string result)
        {
            if(PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(result));
            }
        }
       
        public void cancelScreen(MainWindow MW)
        {
            MW.Close();
        }
        public void displayResult(object[] val)
        {
            string message = "Confirmed";
            MessageBox.Show(message);
        }
    }
}
