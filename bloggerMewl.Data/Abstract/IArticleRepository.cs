using bloggerMewl.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bloggerMewl.Data.Abstract
{
    public interface IArticleRepository:IEntityRepository<Article>
    {
    }
}
