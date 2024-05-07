using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerHW
{
    public class Product
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public override string ToString()
        {
            return $"Name - {Name} | Price - {Price}";
        }
    }
}
