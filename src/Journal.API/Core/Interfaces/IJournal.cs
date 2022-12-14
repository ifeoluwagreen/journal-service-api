using Journal.API.Core.DTOs.Requests;
using Journal.API.Core.DTOs.Responses;
using System;

namespace Journal.API.Core.Interfaces
{
    public interface IJournal
    {
        public SuccessResponse AddJournal(AddJournalRequest request);
        public SuccessResponse GetJournal(Guid journalid);
        public SuccessResponse DeleteJournal(Guid journalid);
        public SuccessResponse UpdateJournal(Guid journalid, AddJournalRequest request);
        public SuccessResponse AddJournalEntry(AddJournalEntry request, Guid journalid);
        public SuccessResponse GetJournalEntry(Guid journalid);
        public SuccessResponse DeleteJournalEntry(Guid journalid, Guid entryid);
        public SuccessResponse UpdateJournalEntry(Guid journalid, Guid entryid, AddJournalRequest request);

    }
}
