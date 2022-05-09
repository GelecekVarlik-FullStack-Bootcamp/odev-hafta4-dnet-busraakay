using Homework4.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Entity.Models
{
    public class User : EntityBase
    {
        [Key]
        public int UserId { get; set; }
        public string Password { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
