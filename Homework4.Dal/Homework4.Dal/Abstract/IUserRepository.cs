﻿using Homework4.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Dal.Abstract
{
    public interface IUserRepository
    {
        User Login(User login);
    }
}