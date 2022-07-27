using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System
{
    internal class students
    {
        public void stu()

        {

            Console.WriteLine();
            Console.WriteLine("Hello You Have Just Entered In Student Portal");
            Console.WriteLine("Enter 1 to BorrowBook");
            Console.WriteLine("Enter 2 to ReturnBook");
            Console.WriteLine("Enter 3 to View Available Books");
            Console.WriteLine("Enter 4 to End The Session");
            Console.WriteLine();
            int x = Convert.ToInt32(Console.ReadLine());

            Addition t = new Addition();

            StuBook obj = new StuBook();

            if (x == 1)
            {
                obj.BorrowOperation();
                stu();
            }
            else if (x == 2)
            {
                obj.ReturnOperation();
                stu();
            }
            else if (x == 3)
            {
                foreach (Book b in t)
                {
                    Console.WriteLine($"Book ID-{b.ID}  Book Name-{b.Name}");
                }
                stu();

            }
            else if (x == 4)
            {

            }


        }



    }
}
