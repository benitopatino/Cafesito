using System;
using Cafesito.Models;

namespace Cafesito.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public byte CategoryId { get; set; }
        public decimal Price { get; set; }
        public DateTime DateAdded { get; set; }
        public bool Active { get; set; }

    }
}
