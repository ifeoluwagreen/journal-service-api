
using System;

namespace Journal.API.Core.Models
{
    public class Journall: BaseModel
    {
        public long CustomerId { get; set; }
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
