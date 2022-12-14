using Journal.API.Core.Context;
using Journal.API.Core.Models;

namespace Journal.API.Core.Repositories
{
    public class JournalEntryRepository : BaseRepository<JournalEntry>
    {
        public JournalEntryRepository(DatabaseContext context) : base(context)
        {
        }

    }

}
