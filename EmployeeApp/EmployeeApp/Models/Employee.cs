using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp.Models
{
    public class Employee
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Occupation { get; set; }
        public string EmailAddress { get; set; }
        public string TelephoneNumber { get; set; }
    }
}
