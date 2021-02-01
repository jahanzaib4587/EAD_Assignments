using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Task2
{
    class cancel : ICommand
    {
        private viewModel vM;
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;

            }
            remove

            {
                CommandManager.RequerySuggested -= value;
            }
            
        }
        public cancel(viewModel vM2)
        {
            this.vM = vM2;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        
      
        public void Execute(object parameter)
        {
            vM.cancelScreen(parameter as MainWindow);
        }
    }
}
