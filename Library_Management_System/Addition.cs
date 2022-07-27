using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System
{
    internal class Addition : IEnumerable
    {
        private List<Book> books;
        public void ADD(Book NewBook)
        {
            if (books == null)
            {
                books = new List<Book>();

            }
            books.Add(NewBook);
        }

        public IEnumerator GetEnumerator()
        {
            if (books != null)
            {
                return books.GetEnumerator();
            }
            else
            {
                return null;
            }

        }

    }
     public class Book
    {
        public Boolean IsBorrowed { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
