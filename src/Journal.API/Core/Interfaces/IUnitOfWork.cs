using Journal.API.Core.Repositories;

namespace Journal.API.Core.Interfaces
{
    public interface IUnitOfWork
    {
        void Commit();
        void RollBack();
        JournalEntryRepository JournalEntryRepository { get; }
        JournalRepository JournalRepository { get; }
        CustomerRepository CustomerRepository { get; }
    }
}
