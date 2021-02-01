using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Assignment2_EAD.ViewModels
{
    class BasicViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void onPropertyChange(string value)
        {
            if(PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(value));
            }
        }
    }
}
