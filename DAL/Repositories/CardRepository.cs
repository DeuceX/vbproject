using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Context;
using DAL.Repositories.Interfaces;
using Domain.Card;

namespace DAL.Repositories
{
    public class CardRepository : ICardRepository
    {
        private ApplicationContext _context;

        public CardRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<Card> GetAll()
        {
            return _context.Card;
        }

        public Card GetById(int id)
        {
            return _context.Card.FirstOrDefault(c => c.Id == id);
        }

        public void Delete(Card card)
        {
            _context.Card.Remove(card);
        }

        public void Update(Card card)
        {
            if (card == null)
            {
                throw new ArgumentNullException("entity");
            }
            _context.SaveChanges();
        }

        public void Insert(Card card)
        {
            _context.Add(card);
        }
    }
}
