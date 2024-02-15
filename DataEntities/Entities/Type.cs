using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities.Entities
{
    public abstract class Type : Entity
    {
        public string Status { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
