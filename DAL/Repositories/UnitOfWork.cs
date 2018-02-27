using System;
using DAL.Context;
using DAL.Repositories.Interfaces;

namespace DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private ApplicationContext _context;

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
        }

        public ICardRepository CardRepository { get; set; }
        public ICardSetRepository CardSetRepository { get; set; }
        public ICustomerRepository CustomerRepository { get; set; }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public virtual void Dispose(bool dispose)
        {
            if (dispose && _context != null)
            {
                _context.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
