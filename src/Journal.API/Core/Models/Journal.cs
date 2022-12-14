
using Microsoft.EntityFrameworkCore;
using System;

namespace Journal.API.Core.Models
{
    [Index(nameof(Guid), Name = "guid_journal_ix", IsUnique = true)]
    public class Journall: BaseModel
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
