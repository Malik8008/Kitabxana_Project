using System;

namespace Kitabxana_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Ewref","Kasib Yazar",112);
            Book book2 = new Book("Dilenci","Semi Ram",65);
            Book book3 = new Book("Kasib Ata","Albert Indi",107);
            Book book4 = new Book("Canguden","Viktor Huqo",178);
           
           

            Library library = new Library();
            library.Books.Add(book1);
            library.Books.Add(book2);  
            library.Books.Add(book3);
            library.Books.Add(book4);

            //foreach (var item in library.FindAllBooksByName("Dilenci"))
            //{
            //    Console.WriteLine(item.Name);
            //}


            //library.RemoveAllBooksByName("Canguden");
            //foreach (var item in library.Books)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //foreach (var item in library.SearchBooks("Kasib Ata"))
            //{
            //    Console.WriteLine(item.Name);
            //}

            //foreach (var item in library.FindAllBooksByPageCountRange(108,180))
            //{
            //    Console.WriteLine(item.Name);
            //}

            library.RemoveByCode("EW10");
            foreach (var item in library.Books)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
