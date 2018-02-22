using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class CardSet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
    }
}
