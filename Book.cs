using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Book
    {
        protected string Title;
        protected int Pages;
        protected int PubYear;
        public Book(string Title, int Pages, int PubYear)
        {
            this.Title = Title;
            this.Pages = Pages;
            this.PubYear = PubYear;
        }
        public string title
        {
            get { return Title; }
            set{ Title = value; }
        }
        public int pages
        { 
            get { return Pages; }
            set { Pages = value; }
        }
        public int pubYear
        {
            get { return PubYear; }
            set { PubYear = value; }
        }
    }
}
