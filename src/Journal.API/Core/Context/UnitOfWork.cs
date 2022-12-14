using Journal.API.Core.Repositories;

namespace Journal.API.Core.Context
{
    public class UnitOfWork
    {
        private readonly DatabaseContext _context;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        public JournalRepository JournalRepository => new JournalRepository(_context);
        public CustomerRepository CustomerRepository => new CustomerRepository(_context);
        public JournalEntryRepository JournalEntryRepository => new JournalEntryRepository(_context);

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void RollBack()
        {
            _context.Dispose();
        }

    }
}
