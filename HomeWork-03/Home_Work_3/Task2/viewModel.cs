using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Task2
{
    class viewModel
    {
        public Submit submit { get; set; }
        public cancel cancelVar { get; set; }

        public viewModel()
        {
            submit = new Submit(this);
            cancelVar = new cancel(this);
        }
        public bool doExecute(object[] val)
        {
            if(val!=null )
            {
               
                    string name = val[0] as string;
                    string gender = val[1] as string;
                    var yes = val[2] as System.Windows.Controls.RadioButton;
                    var no = val[3] as System.Windows.Controls.RadioButton;
               

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(gender) || yes.IsChecked == false || no.IsChecked == false)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
              

            }
            else
            {
                return false;
            }
        }
        public void cancelScreen(MainWindow MW)
        {
            MW.Close();
        }
        public void displayResult(object[] values)
        {
            string isGraduate="";
            var checkVal = values[2] as System.Windows.Controls.RadioButton;
            if(checkVal.IsChecked==false)
            {
                isGraduate = "Not Graduated";
            }
            else
            {
                isGraduate = "Graduated";
            }
            string result = "Name:  " + values[0].ToString() +"\n" + "Gender: " + values[1].ToString() + "\n" + "Graduated: " + isGraduate;
            MessageBox.Show(result);
        }
    }
}
