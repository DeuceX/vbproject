using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Card> Cards { get; }
        IRepository<CardSet> CardSets { get; }
        void Save();
    }
}
