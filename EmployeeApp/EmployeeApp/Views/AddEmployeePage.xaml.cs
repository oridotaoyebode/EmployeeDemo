using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmployeeApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddEmployeePage : ContentPage
    {
        public AddEmployeePage()
        {
            InitializeComponent();
            this.BindingContext = new AddEmployeeViewModel();
        }
    }
}