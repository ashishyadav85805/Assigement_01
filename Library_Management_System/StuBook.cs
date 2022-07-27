﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Library_Management_System
{
    internal class StuBook :students
    {
        public void BorrowOperation()
        {


            Console.WriteLine("Press 1 to Borrow");
            Console.WriteLine("Press 2 to Exit");
            Console.WriteLine();

            int val = int.Parse(Console.ReadLine());

            if (val == 1)
            {
                StuBorrow.BorrowBook();
            }
            else if (val == 2)
            {
                stu();
            }

            else
            {
                Console.WriteLine("Invalid option ");
            }

        }

        public void ReturnOperation()
        {
            Console.WriteLine("Press 1 to Return");
            Console.WriteLine("Press 2 to Exit");
            Console.WriteLine();

            int value = int.Parse(Console.ReadLine());

            if (value == 1)
            {
                StuBorrow.ReturnBook();
            }
            else if (value == 2)
            {
                stu();
            }
            else
            {
                Console.WriteLine("Invalid option");
            }
        }
    }
}
