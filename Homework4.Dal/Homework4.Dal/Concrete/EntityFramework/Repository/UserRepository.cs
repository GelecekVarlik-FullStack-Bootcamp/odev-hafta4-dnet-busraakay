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
    class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {

        }

        public User Login(User login)
        {
            var user = dbset.Where(x => x.Employee.EmployeeMail == login.Employee.EmployeeMail && x.Password == login.Password).SingleOrDefault();

            return user;
        }
    }
}
