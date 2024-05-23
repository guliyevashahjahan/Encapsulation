using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_05_22
{
    public class Book : Product
    {
        public Book(int id, string name, double price, string genre) : base(id, name, price)
        {
            Genre = genre;
        }
        public Book(int id, string name, double price, string genre,int count) : base(id, name, price)
        {
            Genre=genre;
            Count = count;
        }

        public string Genre { get; set; }
    }
}
