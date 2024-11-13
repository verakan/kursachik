using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursachik
{
    class Product
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public  float Price { get; set; }

        public string Name;
        public Product() { }
        public Product(string Name)
        {
            this.Name = Name;

        }
    }
}
