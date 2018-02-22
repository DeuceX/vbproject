﻿using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;
using DAL.Entities.Map;
using Microsoft.EntityFrameworkCore;

namespace DAL.EF
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<CardSet> CardSets { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new CardMap(modelBuilder.Entity<Card>());
        }

    }

}
