using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651_Adv_Prog.c01
{
    class Book_1_n
    {
        private string _name;
        private Author[] _authors;
        private double _price;
        private int _qty = 0;

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        public Author[] Authors
        {
            get { return _authors; }
            private set { _authors = value; }
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

        public Book_1_n(string name, Author[] authors, double price)
        {
            this.Name = name;
            this.Authors = authors;
            this.Price = price;
        }

        public Book_1_n(string name, Author[] authors, double price, int qty)
        {
            this.Name = name;
            this.Authors = authors;
            this.Price = price;
            this.Qty = qty;
        }

        public string AuthorNames()
        {
            string authorNames = "";
            for (int i = 0; i < Authors.Length; i++)
            {
                authorNames += Authors[i].Name;
                if (i != Authors.Length - 1)
                {
                    authorNames += ", ";
                }
            }
            return authorNames;
        }

        public override string ToString()
        {
            return "Book [Name = " + Name + ", " + "Authors = {" + AuthorNames() + "}, Price = " + Price + ", Qty = " + Qty + "]";
        }
    }
}
