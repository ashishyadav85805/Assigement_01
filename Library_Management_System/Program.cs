using System;

namespace Library_Management_System
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please select any one : ");
            Console.WriteLine(" Press 1 For 'Admin' ");
            Console.WriteLine(" Press 2 For 'Student' ");
            string chosen = Console.ReadLine();
            int x = int.Parse(chosen);

            admin a = new admin();
            students s = new students();

            switch (x)
            {
                case 1:
                    a.adm();
                    break;
                case 2:
                    s.stu();
                    break;

            }
        }
    }

}
