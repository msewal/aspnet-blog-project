using bloggerMewl.Data.Abstract;
using bloggerMewl.Entities.Concrete;
using bloggerMewl.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bloggerMewl.Data.Concrete
{
    public class CategoryRepository : EfEntityRepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext context) : base(context)
        {
        }
    }
}
