using Journal.API.Core.Context;
using Journal.API.Core.Models;
using System;
using System.Linq;

namespace Journal.API.Core.Repositories
{
    public class JournalRepository : BaseRepository<Journall>
    {
        public JournalRepository(DatabaseContext context) : base(context)
        {
        }

        public Journall AddJournall(string name)
        {
            var newjournal = new Journall
            {
                Guid = Guid.NewGuid(),
                Name = name,
            };

            Add(newjournal);
            Commit();

            return newjournal;
        }

        public Journall GetJournal(Guid guid)
        {
            return FindByQuery("select * from journal where guid={0} and datedeleted is null", new object[] { guid }).FirstOrDefault();
        }
    }
}
