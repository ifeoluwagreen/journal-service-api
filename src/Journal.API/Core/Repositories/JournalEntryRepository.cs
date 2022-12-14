using Journal.API.Core.Context;
using Journal.API.Core.Models;
using System;
using System.Linq;

namespace Journal.API.Core.Repositories
{
    public class JournalEntryRepository : BaseRepository<JournalEntry>
    {
        public JournalEntryRepository(DatabaseContext context) : base(context)
        {
        }

        public JournalEntry AddJournalEntry(string entry, long journalid)
        {
            var newjournal = new JournalEntry
            {
                Guid = Guid.NewGuid(),
                Entry = entry,
                JournalId = journalid
            };

            Add(newjournal);
            Commit();

            return newjournal;
        }

        public JournalEntry GetJournal(Guid guid)
        {
            return FindByQuery("select * from journalentries where guid={0} and datedeleted is null", new object[] { guid }).FirstOrDefault();
        }

        public JournalEntry GetJournal(Guid guid, long journalid)
        {
            return FindByQuery("select * from journalentries where guid={0} and journalid={1} and datedeleted is null", new object[] { guid, journalid }).FirstOrDefault();
        }

    }

}
