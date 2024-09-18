using bloggerMewl.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace bloggerMewl.Entities.Concrete
{
    public class Article : EntityBase, IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public string SeoAuthor { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTags { get; set; }
        public int ViewsCount { get; set; }
        public int CommentCount => Comments?.Count ?? 0; 
        public string Thumbnail { get; set; }
        public string CreatedByName { get; set; }
        public string ModifiedByName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string? Note { get; set; } // Nullable string
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ViewCount { get; set; }
        //
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }

}
