using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ListExample.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        bool isBusy = false;
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
                    OnPropertyChanged("IsBusy");
                    OnPropertyChanged("IsNotBusy");
                }
            }
        }

        public bool IsNotBusy
        {
            get
            {
                return !isBusy;
            }
        }
    }
}
