using Journal.API.Core.Context;
using Journal.API.Core.Models;

namespace Journal.API.Core.Repositories
{
    public class JournalRepository : BaseRepository<Journall>
    {
        public JournalRepository(DatabaseContext context) : base(context)
        {
        }

    }
}
