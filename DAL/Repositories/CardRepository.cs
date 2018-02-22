using System;
using System.Collections.Generic;
using System.Linq;
using DAL.EF;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

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

        public void Insert(Card entity)
        {
            throw new NotImplementedException();
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
            _context.SaveChanges();
        }

        public void Update(Card card)
        {
            _context.Entry(card).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(Card entity)
        {
            _context.Cards.Remove(entity);
        }

        public void Remove(Card entity)
        {
            _context.Cards.Remove(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
