using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities.Entities
{
    public class Blog : Entity
    {
        public string Url { get; set; }
        public bool IsPublic { get; set; }
        public BlogType BlogType { get; set; }
        public int BlogTypeId { get; set; }
        public List<Post> Posts { get; set; }
    }
}
