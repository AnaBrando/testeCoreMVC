using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senac2.Models
{
    public class EntityBase
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedData { get; set; }
    }
}
