using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Dto
{
    public class CardDto
    {
        public int Id { get; set; }
        public int CardSetId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public List<string> Types { get; set; }
    }
}
