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
    public class ArticleRepository : EfEntityRepositoryBase<Article>, IArticleRepository
    {
        public ArticleRepository(DbContext context) : base(context)
        {
        }
    }
}