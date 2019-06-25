using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginExample.ViewModels
{
    public class LoginPageViewModel: BaseViewModel
    {
        public LoginPageViewModel() {
            LoginCommand = new Command(LoginAsync, canLogin);
        }

        bool canLogin()
        {
            return IsNotBusy;
        }

        async void LoginAsync()
        {
            
            IsBusy = true;
            ((Command)LoginCommand).ChangeCanExecute();
            await Task.Delay(3000);
            IsBusy = false;
            ((Command)LoginCommand).ChangeCanExecute();

        }

        private string userName;

        public string UserName
        {
            get { return userName; }
            set {
                if (value != userName)
                {
                    userName = value;
                    OnPropertyChanged(nameof(UserName));
                }
            }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set {
                if (value != password)
                {
                    password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }
        public ICommand LoginCommand { get; private set; }

    }
}
