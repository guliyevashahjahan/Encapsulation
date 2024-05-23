using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_05_22
{
    public class Product
    {
        private double _price;
        private int _count;
        public Product(int id,string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public Product(int id, string name, double price, int count): this(id,name,price)
        {
            Count = count;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price
        {
            get => _price;
            set
            {
                if (value > 0)
                    _price = value;
            }
        }
        public int Count
        {
            get => _count;
            set
            {
                if (value > 0)
                    _count = value;
            }
        }
    }
}
