﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Library_Management_System
{
    internal class stuBorrow : students 
    {
        public static void BorrowBook()
        {
            Addition t = new Addition();
            Console.Write("Enter Book Code ");
            int borrow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            foreach (Book b in t)
            {
                if (b.ID.Equals(borrow))
                {
                    if (b.IsBorrowed == true)
                    {
                        Console.WriteLine("Book is already taken");

                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(b.ID + ":" + b.Name);
                        Console.WriteLine("Book Successfully Issued");
                        b.IsBorrowed = true;
                        Console.WriteLine();

                    }
                }

            }

        }
        public static void ReturnBook()
        {
            Addition t = new Addition();
            Console.Write("Enter Book Code To Return");
            int returning = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            foreach (Book b in t)
            {
                if (b.ID.Equals(returning))
                {
                    if (b.IsBorrowed  == true)
                    {
                        b.IsBorrowed = false;

                        Console.WriteLine("Book is succesfully returned");
                        Console.WriteLine();

                    }
                    else
                    {
                        Console.WriteLine("You Have not Borrowed this book");
                        Console.WriteLine();

                    }
                }

            }
        }



    }
}
