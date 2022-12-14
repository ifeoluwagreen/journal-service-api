using Journal.API.Core.DTOs.Requests;
using Journal.API.Core.DTOs.Responses;
using Journal.API.Core.Interfaces;
using Microsoft.Extensions.Logging;
using System;

namespace Journal.API.Core.Services
{
    public class JournalService: IJournal
    {
        private ILogger<JournalService> _logger;

        public JournalService(ILogger<JournalService> logger, IUnitOfWork work)
        {
            _logger = logger;
        }

        public SuccessResponse AddJournal(AddJournalRequest request)
        {
            throw new NotImplementedException();
        }

        public SuccessResponse AddJournalEntry(AddJournalEntry request, Guid journalid)
        {
            throw new NotImplementedException();
        }

        public SuccessResponse DeleteJournal(Guid journalid)
        {
            throw new NotImplementedException();
        }

        public SuccessResponse DeleteJournalEntry(Guid journalid, Guid entryid)
        {
            throw new NotImplementedException();
        }

        public SuccessResponse GetJournal(Guid journalid)
        {
            throw new NotImplementedException();
        }

        public SuccessResponse GetJournalEntry(Guid journalid)
        {
            throw new NotImplementedException();
        }

        public SuccessResponse UpdateJournal(Guid journalid, AddJournalRequest request)
        {
            throw new NotImplementedException();
        }

        public SuccessResponse UpdateJournalEntry(Guid journalid, Guid entryid, AddJournalRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
