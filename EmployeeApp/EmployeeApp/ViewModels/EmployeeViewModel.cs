using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Windows.Input;
using EmployeeApp.Models;
using EmployeeApp.Views;
using MvvmHelpers;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace EmployeeApp.ViewModels
{
    public class EmployeeViewModel : BaseViewModel
    {
        private readonly INavigation _navigation;

        private ObservableCollection<Employee> _employees;
        public ObservableCollection<Employee> Employees
        {
            get => _employees;
            set => SetProperty(ref _employees, value);
        }


        public EmployeeViewModel(INavigation navigation)
        {
            _navigation = navigation;
            GetEmployees();
        }

        private async void GetEmployees()
        {
            try
            {
                var httpClient = new HttpClient();
                var apiResponse =
                    await httpClient.GetAsync("https://test20190610011039.azurewebsites.net/api/Employees");
                if (apiResponse.IsSuccessStatusCode)
                {
                    string apiJson = await apiResponse.Content.ReadAsStringAsync();

                    List<Employee> employees =
                        JsonConvert.DeserializeObject<List<Employee>>(apiJson);
                    Employees = new ObservableCollection<Employee>(employees);
                }
            }
            catch (Exception e)
            {   
               
            }
           
            
        }

        public ICommand GotoAddNewEmployeePageCommand => new Command(async () =>
        {
            await _navigation.PushAsync(new AddEmployeePage());
        });

        //public ICommand GotoWhateverPageCommand => new Command<string>(p =>
        //{

        //});




    }
}
