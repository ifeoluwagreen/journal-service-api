using Newtonsoft.Json;
using System;

namespace Journal.API.Core.Models
{
    public class Customer : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string EmailAddress { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
        public DateTime? AccountLockedUntil { get; set; }
        public DateTime? DateLocked { get; set; }
        [JsonIgnore]
        public int? PasswordTries { get; set; }
    }
}
