using System;
using System.Windows;
using System.Windows.Input;

namespace Family.ViewModel
{
    public class NewFileCommand : ICommand
    {
        public NewFileCommand(MainWindowViewModel viewModel)
        {
            this.ViewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            ViewModel.NewFile();
        }

        public MainWindowViewModel ViewModel { get; set; }
        public event EventHandler CanExecuteChanged;
    }
    public class OpenFileCommand : ICommand
    {
        public OpenFileCommand(MainWindowViewModel viewModel)
        {
            this.ViewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            ViewModel.OpenFile();
        }

        public MainWindowViewModel ViewModel { get; set; }
        public event EventHandler CanExecuteChanged;
    }
    public class SaveFileCommand : ICommand
    {
        public SaveFileCommand(MainWindowViewModel viewModel)
        {
            this.ViewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            ViewModel.SaveFile();
        }

        public MainWindowViewModel ViewModel { get; set; }
        public event EventHandler CanExecuteChanged;
    }
    public class ExitCommand : ICommand
    {
        public ExitCommand(MainWindowViewModel viewModel)
        {
            this.ViewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            Window window = parameter as Window;

            if (window != null)
            {
                window.Close();
            }
        }

        public MainWindowViewModel ViewModel { get; set; }
        public event EventHandler CanExecuteChanged;
    }
}