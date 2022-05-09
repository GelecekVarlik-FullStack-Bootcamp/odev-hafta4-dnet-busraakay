using Homework4.Entity.Dto;
using Homework4.Entity.Models;
using Homework4.Interface;
using Homework4.WepApi.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework4.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ApiBaseController<IDepartmentService, Department, DtoDepartment>
    {
        private readonly IDepartmentService departmentService;
        public DepartmentController(IDepartmentService departmentService) : base(departmentService)
        {
            this.departmentService = departmentService;
        }

    }
}
