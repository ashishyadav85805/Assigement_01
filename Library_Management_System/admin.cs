using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System
{
    internal class admin
    {
        public void adm()
        {
            Console.WriteLine("Select Any One >>>");
            Console.WriteLine();
            Console.WriteLine("What do you want to manage today?");
            Console.WriteLine("[1] for Books, [2] for Newspaper ");

            admin a = new admin();

            string LibrarianChoice = Console.ReadLine();
            int y = int.Parse(LibrarianChoice);

            Books b = new Books();

            if (y == 1)
            {
                b.B();
            }
            else
            {
                a.adm();

            }


        }
    }
}
