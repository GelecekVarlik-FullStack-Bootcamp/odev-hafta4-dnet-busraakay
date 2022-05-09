using Homework4.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Entity.Dto
{
    public class DtoUser : DtoBase
    {
        public int UserId { get; set; }
        public string Password { get; set; }
        public int EmployeeId { get; set; }
    }
}
