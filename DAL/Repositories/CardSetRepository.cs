using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DAL.EF;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace DAL.Repositories
{
    class CardSetRepository : ICardSetRepository
    {
        private readonly CardSetContext _context;

        public CardSetRepository(CardSetContext context)
        {
            _context = context;
        }

        public IEnumerable<CardSet> GetAll()
        {
            return _context.CardSets;
        }

        public CardSet Get(int id)
        {
            return _context.CardSets.FirstOrDefault(cs => cs.Id == id);
        }

        public IEnumerable<CardSet> Find(Func<CardSet, bool> predicate)
        {
            return _context.CardSets.Where(predicate);
        }

        public void Create(CardSet cardSet)
        {
            _context.CardSets.Add(cardSet);
        }

        public void Update(CardSet cardSet)
        {
            _context.Entry(cardSet).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            CardSet cardSet = _context.CardSets.FirstOrDefault(cs => cs.Id == id);
            if (cardSet != null)
                _context.CardSets.Remove(cardSet);
        }
    }
}
