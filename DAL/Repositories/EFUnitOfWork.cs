using System;
using System.Collections.Generic;
using System.Text;
using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private CardContext cardContext;
        private CardSetContext cardSetContext;
        private CardRepository cardRepository;
        private CardSetRepository cardSetRepository;

        public EFUnitOfWork(string connectionString)
        {
            cardContext = new CardContext(connectionString);
            cardSetContext = new CardSetContext(connectionString);
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    cardContext.Dispose();
                    cardSetContext.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IRepository<Card> Cards => cardRepository ?? (cardRepository = new CardRepository(cardContext));
        public IRepository<CardSet> CardSets => cardSetRepository ?? (cardSetRepository = new CardSetRepository(cardSetContext));
        public void Save()
        {
            cardContext.SaveChanges();
            cardSetContext.SaveChanges();
        }
    }
}
