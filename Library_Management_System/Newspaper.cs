using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System
{
    internal class Newspaper
    {
       
        public void news()
        {
            Console.WriteLine("[1] available newspaper");

            int x  = Convert.ToInt32(Console.ReadLine());

            News1 n = new News1();

            if(x == 1)
            {
                foreach (Paper y in n)
                {
                    Console.WriteLine($"Title- {y.Title}");
                }
                Console.ReadLine();
            }

        }
    }
}
