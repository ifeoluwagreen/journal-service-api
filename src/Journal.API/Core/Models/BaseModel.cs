using Journal.API.Core.Interfaces;
using Newtonsoft.Json;
using System;

namespace Journal.API.Core.Models
{
    public class BaseModel: IModel
    {
        public long Id { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateDeleted { get; set; }
        [JsonIgnore]
        public long? CreatedBy { get; set; } = -1;
        [JsonIgnore]
        public long? UpdatedBy { get; set; }
        [JsonIgnore]
        public long? DeletedBy { get; set; }

    }
}
