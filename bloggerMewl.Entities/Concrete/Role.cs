using bloggerMewl.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace bloggerMewl.Entities.Concrete
{
    public class Role : EntityBase, IEntity
    {
<<<<<<< HEAD
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<User> Users { get; set; }
=======
        public class Role : EntityBase, IEntity
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public ICollection<User> Users { get; set; }
        }
>>>>>>> 00095b5c65a5248f3a0f859ab44367647f2e7ec8
    }
