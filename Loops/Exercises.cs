using System;
using System.Collections.Generic;
using System.Numerics;

namespace Loops
{
    class Exercises
    {
        static void Main(string[] args)
        {
            //1.Write a program that prints on the console the numbers from 1 to N. 
            //The number N should be read from the standard input.
            Console.Write("Enter a positive integer N and I will print numbers 1 to N on console: ");
            int numberN = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberN; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            EndOfScript();


            //2.Write a program that prints on the console the numbers from 1 to N,
            //which are not divisible by 3 and 7 simultaneously.The number N
            //should be read from the standard input.
            Console.Write("Enter a number N. Output will be numbers divisible by 3 and 7: ");
            int numberNN = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberNN; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();

            EndOfScript();

            //3.Write a program that reads from the console a series of integers and
            //prints the smallest and largest of them.
            Console.Write("Enter a serie of the numbers. Output will be smalles and biggest number: ");            
            List<int> zadaneCislaTransformedList = new List<int>();
            foreach (var item in Console.ReadLine().Split(new char[] { ' ' }))
            {
                zadaneCislaTransformedList.Add(int.Parse(item));
            }
            int[] zadaneCislaInt = zadaneCislaTransformedList.ToArray();
            Array.Sort(zadaneCislaInt);
            Console.WriteLine($"The smallest one is {zadaneCislaInt[0]} " +
                $"and the biggest one is {zadaneCislaInt[zadaneCislaInt.Length - 1]}");

            EndOfScript();

            //4.Write a program that prints all possible cards from a standard deck
            //of cards, without jokers(there are 52 cards: 4 suits of 13 cards).             
            string[] colors = {"Heart" , "Club" , "Diamond" , "Spade"};
            foreach (var color in colors)
            {
                for (int i = 2; i <= 14; i++)
                {                    
                    switch (i)
                    {
                        case 11:
                            Console.Write("{0}_{1} ", color, "Jack");
                            break;
                        case 12:
                            Console.Write("{0}_{1} ", color, "Queen");
                            break;
                        case 13:
                            Console.Write("{0}_{1} ", color, "King");
                            break;
                        case 14:
                            Console.Write("{0}_{1} ", color, "Ace");
                            break;
                        default:
                            Console.Write("{0}_{1} ", color, i);
                            break;
                    }
                }
                Console.WriteLine();
            }            
            
            EndOfScript();

            //5.Write a program that reads from the console number N and print the sum
            //of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 
            //13, 21, 34, 55, 89, 144, 233, 377, … 
            Console.WriteLine("Enter integer N and I will print the sum of the first N members of the Fibonacci sequence.");
            Console.Write("N: ");
            int numberF = int.Parse(Console.ReadLine());
            int number1 = 0;
            int number2 = 1;            
            int nextNumber = 1;            
            int sumOfFibonacci = 1;            
            Console.Write($"{number1} {number2} ");
            for (int i = 3; i <= numberF; i++)            
            {
                sumOfFibonacci += nextNumber;
                Console.Write($"{nextNumber} ");
                number1 = number2;
                number2 = nextNumber;
                nextNumber = number1 + number2;
            }
            Console.WriteLine();
            Console.WriteLine("Sum = " + sumOfFibonacci);

            EndOfScript();

            //6.Write a program that calculates N!/ K! for given N and K(1 < K < N).
            Console.WriteLine("Enter two integers N and K where (1 < K < N) and I will calculate N! / K!.");
            Console.Write("Enter N: ");
            //added a reference to System.Numerics assembly in the project
            //then added using System.Numerics to use BigInteger class
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            BigInteger k = BigInteger.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (BigInteger i = (k + 1); i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine("The result for {0}! / {1}! is {2:E8}",n,k,result);

            EndOfScript();


            //7.Write a program that calculates N!*K!/ (N - K)! for given N and K
            //(1 < K < N).

            //8.In combinatorics, the Catalan numbers are calculated by the following
            //formula: 
            //
            //
            //, for n ≥ 0.Write a program that calculates the nth Catalan number by given n.

            //9.Write a program that for a given integers n and x, calculates the sum: 
            //
            //

            //10.Write a program that reads from the console a positive integer number
            //N(N < 20) and prints a matrix of numbers as on the figures below: 
            //N = 3 
            // 1 2 3
            // 2 3 4
            // 3 4 5
            //
            //N = 4
            // 1 2 3 4
            // 2 3 4 5
            // 3 4 5 6
            // 4 5 6 7

            //11.Write a program that calculates with how many zeroes the factorial of
            //a given number ends.Examples: 
            //N = 10->N! = 3628800-> 2
            //N = 20->N! = 2432902008176640000-> 4

            //12.Write a program that converts a given number from decimal to binary
            //notation(numeral system).

            //13.Write a program that converts a given number from binary to decimal
            //notation.

            //14.Write a program that converts a given number from decimal to
            //hexadecimal notation.

            //15.Write a program that converts a given number from hexadecimal to
            //decimal notation.

            //16.Write a program that by a given integer N prints the numbers from 1 to N 
            //in random order.

            //17.Write a program that given two numbers finds their greatest common
            //divisor(GCD) and their least common multiple(LCM).You may use
            //the formula LCM(a, b) = | a * b | / GCD(a, b).

            //18. * Write a program that for a given number n, outputs a matrix in the
            //form of a spiral: 
            //Example for n = 4: 
            //  1  2  3 4
            // 12 13 14 5
            // 11 16 15 6
            // 10  9  8 7

                                          
        }
        static void EndOfScript()
        {
            Console.WriteLine(new String('#', 60));
            Console.WriteLine();
        }
    }
}
