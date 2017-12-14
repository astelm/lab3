using System.ComponentModel;

namespace Family.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}