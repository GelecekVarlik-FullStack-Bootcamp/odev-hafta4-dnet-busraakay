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
    public class RequestController : ApiBaseController<IRequestService, Request, DtoRequest>
    {
        private readonly IRequestService requestService;
        public RequestController(IRequestService requestService) : base(requestService)
        {
            this.requestService = requestService;
        }

    }
}
