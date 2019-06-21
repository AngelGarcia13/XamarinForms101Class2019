using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmApp.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public ICommand DisplayNameCommand { get; private set; }
        public MainPageViewModel()
        {
            Name = "Here goes your name";
            DisplayNameCommand = new Command(DisplayName, CanDisplayName);
        }
        
        private bool CanDisplayName()
        {
            return !IsBusy;
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        string name = "";
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        bool isBusy;
        public bool IsBusy
        {
            get
            {
                return isBusy;
            }
            set
            {
                if (isBusy != value)
                {
                    isBusy = value;
                    ((Command)DisplayNameCommand).ChangeCanExecute();
                    OnPropertyChanged("IsBusy");
                }
            }
        }
        
        
        async void DisplayName()
        {
            IsBusy = true;
            await Task.Delay(3000);
            IsBusy = false;
        }
    }
}
