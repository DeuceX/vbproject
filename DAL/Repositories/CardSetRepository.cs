using System;
using System.Collections.Generic;
using System.Linq;
using DAL.EF;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class CardSetRepository : ICardSetRepository
    {
        private readonly CardSetContext _context;

        public CardSetRepository(CardSetContext context)
        {
            _context = context;
        }

        public IEnumerable<CardSet> GetAll()
        {
            return _context.CardSets.ToList();
        }

        public void Insert(CardSet entity)
        {
            _context.CardSets.Add(entity);
            _context.SaveChanges();
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
            _context.SaveChanges();
        }

        public void Update(CardSet cardSet)
        {
            _context.Entry(cardSet).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(CardSet entity)
        {
            _context.CardSets.Remove(entity);
        }

        public void Remove(CardSet entity)
        {
            _context.CardSets.Remove(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
