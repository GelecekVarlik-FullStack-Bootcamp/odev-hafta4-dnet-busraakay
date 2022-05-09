using Homework4.Entity.Base;
using Homework4.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Entity.Dto
{
    public class DtoEmployee : DtoBase
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public string EmployeeMail { get; set; }
        public string? EmployeePhone { get; set; }


        public int DepartmentId { get; set; }
    }
}
