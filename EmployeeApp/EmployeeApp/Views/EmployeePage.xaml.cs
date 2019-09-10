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
    public partial class EmployeePage : ContentPage
    {
        public EmployeePage()
        {
            
            InitializeComponent();
            BindingContext = new EmployeeViewModel(this.Navigation);
        }
    }
}