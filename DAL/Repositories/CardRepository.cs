using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DAL.EF;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace DAL.Repositories
{
    public class CardRepository : ICardRepository
    {
        private readonly CardContext _context;

        public CardRepository(CardContext context)
        {
            _context = context;
        }

        public IEnumerable<Card> GetAll()
        {
            return _context.Cards;
        }

        public Card Get(int id)
        {
            return _context.Cards.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Card> Find(Func<Card, bool> predicate)
        {
            return _context.Cards.Where(predicate).ToList();
        }

        public void Create(Card card)
        {
            _context.Cards.Add(card);
        }

        public void Update(Card card)
        {
            _context.Entry(card).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Card book = _context.Cards.Find(id);
            if (book != null)
                _context.Cards.Remove(book);
        }
    }
}
