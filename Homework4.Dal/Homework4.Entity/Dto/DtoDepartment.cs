using Homework4.Entity.Base;
using Homework4.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Entity.Dto
{
    public class DtoDepartment : DtoBase
    {
        public int DepartmentId { get; set; }
        public string DepartmentTitle { get; set; }
    }
}
