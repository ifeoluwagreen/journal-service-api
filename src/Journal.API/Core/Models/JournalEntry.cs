using Microsoft.EntityFrameworkCore;
using System;

namespace Journal.API.Core.Models
{
    [Index(nameof(Guid), Name = "guid_journal_entry_ix", IsUnique = true)]
    public class JournalEntry: BaseModel
    {
        public long JournalId { get; set; }
        public Guid Guid { get; set; }
        public string Entry { get; set; }
    }
}
