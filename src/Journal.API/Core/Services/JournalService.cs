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
        private IUnitOfWork _work;


        public JournalService(ILogger<JournalService> logger, IUnitOfWork work)
        {
            _logger = logger;
            _work = work;
        }

        public SuccessResponse AddJournal(AddJournalRequest request)
        {
            var journal = _work.JournalRepository.AddJournall(request.name);
            return new SuccessResponse("successful",journal);
        }

        public SuccessResponse AddJournalEntry(AddJournalEntry request, Guid journalid)
        {
            var journal = _work.JournalRepository.GetJournal(journalid);
            if (journal == null) throw new Exception("invalid journal");

            var journalentry = _work.JournalEntryRepository.AddJournalEntry(request.entry, journal.Id);
            return new SuccessResponse("successful", journalentry);
        }

        public SuccessResponse DeleteJournal(Guid journalid)
        {
            var journal = _work.JournalRepository.GetJournal(journalid);
            if (journal == null) throw new Exception("invalid journal");

            journal.DateDeleted = DateTime.UtcNow;

            _work.JournalRepository.Update(journal);
            _work.Commit();

            return new SuccessResponse("journal deleted successfully");
        }

        public SuccessResponse DeleteJournalEntry(Guid journalid, Guid entryid)
        {
            var journal = _work.JournalRepository.GetJournal(journalid);
            if (journal == null) throw new Exception("journal not found");

            var journalentry = _work.JournalEntryRepository.GetJournal(entryid, journal.Id);
            if (journalentry == null) throw new Exception("journal entry not found");

            journalentry.DateDeleted = DateTime.UtcNow;

            _work.JournalEntryRepository.Update(journalentry);
            _work.Commit();

            return new SuccessResponse("journal entry successfully");
        }

        public SuccessResponse GetJournal(Guid journalid)
        {
            var journal = _work.JournalRepository.GetJournal(journalid);
            if (journal == null) throw new Exception("invalid journal");

            return new SuccessResponse("journal deleted successfully", journal);
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
