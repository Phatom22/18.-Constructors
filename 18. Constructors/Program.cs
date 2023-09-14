using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("harry potter", "jerry.r", 400);
            Book book2 = new Book("potter","jerry", 500);

            Console.WriteLine(book1.title);
            Console.WriteLine(book2.author);
            Console.ReadLine();
        }
    }
}
