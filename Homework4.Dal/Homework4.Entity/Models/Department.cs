using Homework4.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Entity.Models
{
    public class Department : EntityBase
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentTitle { get; set; }

        public List<Employee> Employees { get; set; }
        public List<Request> Requests { get; set; }
    }
}
