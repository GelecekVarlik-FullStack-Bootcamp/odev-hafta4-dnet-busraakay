using Homework4.Entity.Dto;
using Homework4.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Interface
{
    public interface IDepartmentService : IGenericService<Department, DtoDepartment>
    {
    }
}
