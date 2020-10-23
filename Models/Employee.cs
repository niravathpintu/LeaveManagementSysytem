using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
//using LeaveManagementSysytem.Data;
using LeaveManagementSysytem.Models;
namespace LeaveManagementSysytem.Models
{
    public class Employee
    {
       // private LeaveManagementSysytem db = new LeaveManagementSysytem();

        [Required]
        [RegularExpression(@"(\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,6})")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z ]*$")]
        public string EmployeeName { get; set; }

        [Required]
        public string Mobile { get; set; }
        [Required]
        public int Departmentid
        {
            get; set;
        }
        [Required]
        public int Employeeid
        {
            get; set;
        }
        [Required]
        [RegularExpression(@"^[a-zA-Z ]*$")]
        public string EmployeeDesignation { get; set; }

        [Required]
        public bool SpecialPermission
        {
            get; set;
        }
    }
}