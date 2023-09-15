using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c01
{
    class Book_1_1
    {
        private string _name;
        private double _price;
        private int _qty = 0;

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        public Author Author
        {
            get;
            private set;
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public int Qty
        {
            get { return _qty; }
            set { _qty = value; }
        }

        public Book_1_1(string name, Author author, double price)
        {
            this.Name = name;
            this.Author = author;
            this.Price = price;
        }

        public Book_1_1(string name, Author author, double price, int qty)
        {
            this.Name = name;
            this.Author = author;
            this.Price = price;
            this.Qty = qty;
        }

        public override string ToString()
        {
            return "Book [Name = " + Name + ", " + Author.ToString() + ", Price = " + Price + ", Qty = " + Qty + "]";
        }
    }
}
