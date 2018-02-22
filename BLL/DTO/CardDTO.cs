using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class CardDTO
    {
        public int Id { get; set; }
        public int CardSetId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public List<string> Types { get; set; }
    }
}
