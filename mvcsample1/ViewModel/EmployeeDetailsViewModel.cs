using mvcsample1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcsample1.ViewModel
{
    public class EmployeeDetailsViewModel
    {
        public Employee Employee { get; set; }
        public Address Address { get; set; }
        public string PageTitle { get; set; }
        public string PageHeader { get; set; }
    }
}