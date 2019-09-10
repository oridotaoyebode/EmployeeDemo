using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using EmployeeApp.Models;
using MvvmHelpers;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace EmployeeApp.ViewModels
{
    public class AddEmployeeViewModel: BaseViewModel
    {

        private Employee _employee;
        public Employee Employee
        {
            get => _employee;
            set => this.SetProperty(ref _employee, value);
        }

        public AddEmployeeViewModel()
        {
            Employee = new Employee();
            
            
        }
        public ICommand SaveEmployeeCommand => new Command(async () =>
        {
            await SaveEmployee();
        });

        private async Task SaveEmployee()
        {
            try
            {
                var httpClient = new HttpClient();
                var apiReponse = await httpClient.PostAsync("https://test20190610011039.azurewebsites.net/api/Employees",
                    new StringContent(JsonConvert.SerializeObject(Employee), Encoding.UTF8, "application/json"));
                if (apiReponse.IsSuccessStatusCode)
                {
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
               
            }
        }
    }
}
