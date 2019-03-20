using System;
using System.Diagnostics;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int n1, n2, i, j, m = 0, flag = 0;
            Console.Write("Enter the starting range to check Prime: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the ending range to check Prime: ");
            n2 = int.Parse(Console.ReadLine());

            for (i=n1; i<= n2; i++)
            {
                flag = 0;
                m = i / 2;
                for (j=2; j <= m; j++)
                {
                    if (i % j == 0)
                    {
                        Debug.Write(i + " is not Prime.");
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                 Debug.Write(i + " is Prime.");
            }
            
        }
    }
}
