using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Constructors
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        //contructor
        public Book(string aTitle, string aAauthor, int aPages)
        {
            title = aTitle;
            author = aAauthor;
            pages = aPages;
        }
    }
}
