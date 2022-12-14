using Microsoft.EntityFrameworkCore;
using System;

namespace Journal.API.Core.Models
{
    public class JournalEntry: BaseModel
    {
        public long JournalId { get; set; }
        public Guid Guid { get; set; }
        public string Entry { get; set; }
    }
}
