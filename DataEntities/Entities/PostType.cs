using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities.Entities
{
    public class PostType : Type
    {
        public List<Post> Posts { get; set; }

        public PostType()
        {
            Posts = new List<Post>();
        }
    }
}
