using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework4.Dal.Abstract;
using Homework4.Entity.Dto;
using Homework4.Entity.Models;
using Homework4.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace Homework4.Bll
{
    public class RequestManager : GenericManager<Request, DtoRequest>, IRequestService
    {
        public readonly IRequestRepository requestRepository;

        public RequestManager(IServiceProvider service) : base(service)
        {
            requestRepository = service.GetService<IRequestRepository>();
        }
    }
}
