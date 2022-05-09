using Homework4.Dal.Abstract;
using Homework4.Entity.Dto;
using Homework4.Entity.Models;
using Homework4.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Homework4.Bll
{
    public class DepartmentManager : GenericManager<Department, DtoDepartment>, IDepartmentService
    {
        public readonly IDepartmentRepository departmentRepository;

        public DepartmentManager(IServiceProvider service) : base(service)
        {
            departmentRepository = service.GetService<IDepartmentRepository>();
        }

    }
}
