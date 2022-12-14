using Newtonsoft.Json;

namespace Journal.API.Core.Interfaces
{
    public interface IModel
    {
        public long Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateDeleted { get; set; }
        [JsonIgnore]
        public long? CreatedBy { get; set; }
        [JsonIgnore]
        public long? UpdatedBy { get; set; }
        [JsonIgnore]
        public long? DeletedBy { get; set; }

    }
}
