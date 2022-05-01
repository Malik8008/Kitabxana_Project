using System;
using System.Collections.Generic;
using System.Text;

namespace Kitabxana_Project
{
    internal class Library
    {
         public List<Book> Books = new List<Book>();

        public List<Book> FindAllBooksByName(string book)
        {
            return Books.FindAll(x => x.Name.Contains(book));
        }

        public void RemoveAllBooksByName(string bk)
        {
            Console.WriteLine(Books.RemoveAll(x=>x.Name.Contains(bk)));
        }

        public List<Book> SearchBooks(string val)
        {
            return Books.FindAll(book => book.Name.Contains(val) || book.AuthorName.Contains(val) || book.PageCount.ToString().Contains(val));
        }

        public List<Book> FindAllBooksByPageCountRange(int min,int max)
        {
            return Books.FindAll(book => book.PageCount >= min && book.PageCount <= max);
        }

        public void RemoveByCode(string val)
        {
            Book wantedBook = Books.Find(book => book.Code == val);
            if (wantedBook != null)
            {
                Books.Remove(wantedBook);
            }
        }


    }
}
