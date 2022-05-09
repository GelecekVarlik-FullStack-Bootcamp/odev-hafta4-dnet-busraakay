using Homework4.Dal.Abstract;
using Homework4.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Dal.Concrete.EntityFramework.Repository
{
    public class RequestRepository : GenericRepository<Request>, IRequestRepository
    {
        public RequestRepository(DbContext context) : base(context)
        {

        }
    }
}
