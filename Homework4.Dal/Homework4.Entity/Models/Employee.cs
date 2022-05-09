using Homework4.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Entity.Models
{
    public class Employee : EntityBase
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public string EmployeeMail { get; set; }
        public string? EmployeePhone { get; set; }


        public int? DepartmentId { get; set; }
        public Department Department { get; set; }

        public List<Request> Requests { get; set; }
        public List<User> Users { get; set; }


    }
}
