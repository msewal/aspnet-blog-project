﻿using bloggerMewl.Entities.Concrete;
using bloggerMewl.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bloggerMewl.Data.Abstract
{
    public interface IUserRepository : IEntityRepository<User>
    {
    }
}
