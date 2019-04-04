using System;
using System.Diagnostics;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1=5, n2=15, n4;
            //Console.Write("Enter the starting range to check Prime: ");
            //n1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter the ending range to check Prime: ");
            //n2 = int.Parse(Console.ReadLine());
            PrintPrimeNumbers(n1, n2);

            Console.WriteLine();

            n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is: " + Math.Round((Decimal)r1, 3));

            //Console.Write("Enter the number of lines for triangle pattern: ");
            //int val = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int val = 5;
            PrintTriangle(val);

            Console.WriteLine();

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);

            //double doublePI = 3;
            //double h = 2;
            //int o = 3;
            //doublePI = h/ o;
            //Console.Write("Decimal Test: " + doublePI);

            Console.WriteLine();
            Console.Write("Enter somthing to exit: ");
            n4 = int.Parse(Console.ReadLine());

            //Self-reflection: This assignment gave me good exposure to programing in C# with IDE. I've learned a lot about looping, 
            //data types, conditonal statements, printing in console. This is very interesting and i will keep on exporing.
            //Thanks for the great overview of ASP .Net and the developer environment.
        }

        private static void computeFrequency(int[] arr)
        {
            try
            {
                Console.WriteLine("Number  Frequency");
                Console.WriteLine("");
                int i, j, k=1,l=0,m,n=0;
                int[] arr1=new int[8];
                for (i=0; i<8; i++)
                {
                    k = 1;
                    n = 0;
                    for (m=0;m<arr1.Length;m++)
                    {
                        if (arr1[m] == arr[i])
                        { 
                            n = 1;
                            break;
                        }
                    }
                    if (n == 0)
                    {
                        for (j = i + 1; j < arr.Length; j++)
                        {
                            if (arr[i] == arr[j])
                            {
                                k = k + 1;
                            }
                        }
                        arr1[l] = arr[i];
                        l = l + 1;
                        Console.WriteLine(arr[i] + "        " + k);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }

        private static void PrintTriangle(int val)
        {
            try
            {

                int i, j, k = 1, l;
                for (i = 1; i <= val; i++)
                {
                    for (j = 1; j <= k; j++)
                    {
                        Console.Write("*");
                    }
                    k = k + 2;
                    Console.WriteLine("");
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }

        }


        private static double getSeriesResult(int n1)
        {
            try
            { 
                int i, j;
                double r1, r2 = 1;

                if (n1 == 1)
                {
                    r1 = r2 / (n1 + 1);
                    return (r1);
                }
                else
                {
                    r1 = r2 / 2;
                    for (i = 2; i <= n1; i++)
                    {
                        r2 = getfactorial(i);
                        if (i % 2 == 0)
                        {
                            r1 = r1 - (r2 / (i + 1));
                        }
                        else
                        {
                            r1 = r1 + (r2 / (i + 1));
                        }
                    }
                    return (r1);
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }
            return 0;
        }


        private static double getfactorial(int i)
        {
            int j;
            double r2=1;
            for (j = 1; j <= i; j++) 
            {
                r2 = r2 * j;
            }
            //Console.Write("Factorial: "+r2);
            return (r2);
        }

        private static void PrintPrimeNumbers(int n1, int n2)
        {
            try
            {
                // Write your code here
                int i, j, m = 0, flag = 0;
                for (i = n1; i <= n2; i++)
                {
                    flag = 0;
                    m = i / 2;
                    for (j = 2; j <= m; j++)
                    {
                        if (i % j == 0)
                        {
                            Console.Write(i + " is not Prime.");
                            Console.WriteLine();
                            flag = 1;
                            break;
                        }
                    }
                    if (flag == 0)
                    {
                        Console.Write(i + " is Prime.");
                        Console.WriteLine();
                    }

                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }

        }
    }
}