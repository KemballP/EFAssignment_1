using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities.Entities
{
    public class BlogType : Type
    {
        public List<Blog> Blogs { get; set; }

        public BlogType()
        {
            Blogs = new List<Blog>();
        }
    }
}
