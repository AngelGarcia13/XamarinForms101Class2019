using ListExample.Models;
using ListExample.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ListExample.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public INavigation navigationService;
        private string selectedEmployee = "Select an employee";
        public string SelectedEmployee
        {
            get
            {
                return selectedEmployee;
            }
            set
            {
                if (selectedEmployee != value)
                {
                    selectedEmployee = value;
                    OnPropertyChanged("SelectedEmployee");
                }
            }
        }
        private Employee employee;
        public Employee Employee
        {
            get
            {
                return employee;
            }
            set
            {
                employee = value;

                if (employee == null)
                {
                    return;
                }

                ViewDetailsCommand.Execute(employee);

                Employee = null;
            }
        }
        public ObservableCollection<Employee> Employees { get; set; }
        public ICommand AddCommand { get; private set; }
        public ICommand ViewDetailsCommand { get; private set; }
        public MainPageViewModel()
        {
            Employees = new ObservableCollection<Employee>();
            AddCommand = new Command(Add);
            ViewDetailsCommand = new Command<Employee>(ViewDetails);
            GetEmpleados();
        }

        private void ViewDetails(Employee obj)
        {
            //navigationService.PushAsync(new DetailsPage(obj));
            SelectedEmployee= $"{obj.Name}({obj.Age.ToString()}) - {obj.Occupation}";
        }

        void Add()
        {
            Employees.Add(new Employee
            {
                Name = "New Employee",
                Occupation = "....."
            });
        }

        async void GetEmpleados()
        {
            //Going to NASA and fetching data...
            IsBusy = true;
            await Task.Delay(10000);
            var resultado = GetNasaEmployees();
            IsBusy = false;
            foreach (var item in resultado)
            {
                Employees.Add(item);
            }
        }
        public ObservableCollection<Employee> GetNasaEmployees()
        {
            return new ObservableCollection<Employee>
            {
                new Employee{
                    Name = "Juan Carlos",
                    Occupation = "Aviator"
                },
                new Employee{
                    Name = "Leslie Altagracia",
                    Occupation = "Student"
                },
                new Employee{
                    Name = "Angel Rene",
                    Occupation = "Pegabló"
                }
            };
        }
    }
}
