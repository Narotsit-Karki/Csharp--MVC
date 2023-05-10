using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class BaseEntity
    {
        public string Id { get; set; }

        public string LastUpdatedBy { get; set; }

        public DateTimeOffset LastUpdatedAt { get; set; }

        public bool IsActive { get; set; }

    }

    
}
