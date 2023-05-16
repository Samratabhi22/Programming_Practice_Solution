using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Practice
{
    class FibonacciSeries
    {
        static int p1 = 0, p2 = 1, p3;
        //  Method 1      --->    //Iteration process

        static void aain(String[] args)
        {
            Console.WriteLine("Please provide input value");
            int count = Int32.Parse(Console.ReadLine());
            Console.Write(p1 + "  " + p2);

            for (int i = 2; i < count; i++)
            {
                p3 = p1 + p2;
                Console.Write(" " + p3);
                p1 = p2;
                p2 = p3;
            }
            Console.WriteLine();

        }

    }
    class FibonacciSeriesMetho2
    {
        static int p1 = 0, p2 = 1, p3;
        static void fibonacciSeriesMetho2(String[] args)
        {
            Console.WriteLine("Please provide input value");
            int count = Int32.Parse(Console.ReadLine());
            Console.Write(p1 + " " + p2);
            Fibonacci(count - 2);


        }

        private static void Fibonacci(int count)
        {
            if (count > 0)
            {
                p3 = p1 + p2;
                Console.Write(" " + p3);
                p1 = p2;
                p2 = p3;
                Fibonacci(count - 1);
            }
        }


    }
    class Factorial
    {
        static void tain(string[] args)

        {
            //Method 1 --> incremental in for loop

            Console.WriteLine("Please provide input value");
            int number = Int32.Parse(Console.ReadLine());

            int fact = 1;
            //for (int i = 2; i <=number; i++)
            //   // 5 !=  2 * 3 * 4 * 5
            //{
            //    fact = fact * i;
            //}

            //Method 2  ---> decremental in for loop
            //for (int i=number;i>=2; i--) 
            //    //5!=5*4*3*2*1
            //{
            //    fact = fact * i;
            //}
            if (number < 0)
            {
                Console.WriteLine("Please enter the number greater than zero");
            }
            else
            {
                for (int i = number; i >= 2; i--)
                //5!=5*4*3*2*1
                {
                    fact = fact * i;
                }
                Console.WriteLine("{0}! is {1}", number, fact);
            }


        }
        class FactorialRecursion
        {//Using recurssive method 
            static void Recursion(string[] args)
            {
                Console.WriteLine("Please provide factorial number");
                int factNumber = Int32.Parse(Console.ReadLine());
                int result = FactorialCalculation(factNumber);
                Console.WriteLine("Result is : {0} ", result);


            }
            static int fact = 1;
            private static int FactorialCalculation(int factNumber)
            {
                if (factNumber > 0)
                {
                    fact = factNumber * FactorialCalculation(factNumber - 1);
                }
                return fact;
            }
        }

    }
    class FactorialRange
    {
        //Using range
        static void bain(string[] args)
        {
            Console.WriteLine("Please provide upper bound values");
            int upperbound = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= upperbound; i++)
            {
                int fact = 1;
                for (int j = 1; j <= i; j++)
                {
                    fact = fact * j;
                }
                Console.WriteLine("{0}! is {1}", i, fact);
            }
        }
    }
    class VerifyPrime
    {
        static void cain()
        {
            Console.WriteLine("Please provide the Number ");
            int numb = Int32.Parse(Console.ReadLine());
            int count = 0;
            for(int i=1;i<=numb;i++)

            {
                if(numb%i==0)
                {
                    count++;
                }
            }
            if(count==2)
            {
                Console.WriteLine("Number is prime  " + numb);
            }
            else
            {
                Console.WriteLine("Number is not prime "+numb);
            }
        }
    }
    class PrimeRange
    {
        static void dain()
        {
            Console.WriteLine("Please provide the Number ");
            int numb = Int32.Parse(Console.ReadLine());
            Console.WriteLine("=================================");
            
            for (int i = 1; i <= numb; i++)

            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(i);
                }

            }
            
           

        }
    }
    class EvenOddRange
    {
        static void eain()
        {

            Console.WriteLine("Please provide the Number ");
            int numb = Int32.Parse(Console.ReadLine());
            Console.WriteLine("=================================");
            for (int i = 1;i<=numb;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i+" is Even Number");
                }
                else
                {
                    Console.WriteLine(i+" is Odd Number");
                }
            }
        }
    }
    class VeriyEvenOdd
    {
        static void fain()
        {

            Console.WriteLine("Please provide the Number ");
            int numb = Int32.Parse(Console.ReadLine());
            Console.WriteLine("=================================");
            if (numb % 2 == 0)
            {
                Console.WriteLine(numb + " is Even Number");
            }
            else
            {
                Console.WriteLine(numb + " is Odd Number");
            }

        }
    }
    class OddNumber
    {
        static void Main()
        {
            for (int i=0;i<=100;i++)
            {
                if(i%2==0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
           


        }
    }
   
}



