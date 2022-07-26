using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System
{
    internal class admin
    {
        public void adm()
        {
            Console.WriteLine("                    Menu             ");
            Console.WriteLine();
            Console.WriteLine("     <<<<<< Select Any One >>>>>>>      ");
            Console.WriteLine();
            Console.WriteLine(" Ebter 1 for Books  <<<>>>> Enter 2 for Newspaper ");

            admin a = new admin();

            string LibrarianChoice = Console.ReadLine();
            int y = int.Parse(LibrarianChoice);

            Books b = new Books();
            Newspaper p = new Newspaper();

            if (y == 1)
            {
                b.B();
            }
            else
            {
                p.news();

            }


        }
    }
}
