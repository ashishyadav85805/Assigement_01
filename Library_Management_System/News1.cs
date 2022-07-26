using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System
{
    internal class News1 : IEnumerable
    {
        public static List<Paper> Newspaper = new List<Paper>
        {
            new Paper{Title="The Hindu" },
            new Paper{Title="Economics Times"  },
            new Paper{Title="Hindustan Times" },
            new Paper{Title="Times of India" },
        };

        public IEnumerator GetEnumerator()
        {
            if (Newspaper != null)
            {
                return Newspaper.GetEnumerator();
            }
            else
            {
                return null;
            }

        }
    }
    public class Paper
    {
        public string Title { get; set; }
    }
}
