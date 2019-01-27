using System;
using System.Collections.Generic;
using System.Numerics;

namespace Loops
{
    class Exercises
    {
        public static void Main()
        {
            //1.Write a program that prints on the console the numbers from 1 to N. 
            //The number N should be read from the standard input.
            Console.Write("EX1: Enter a positive integer N and I will print numbers 1 to N on console: ");
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
            Console.Write("EX2: Enter a number N. Output will be numbers divisible by 3 and 7: ");
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
            Console.Write("EX3: Enter a serie of the numbers. Output will be smalles and biggest number: ");            
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
            Console.WriteLine("EX4: Printing all possible cards from a standard deck of cards");
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
            Console.WriteLine("EX5: Enter integer N > 1 and I will print the sum of the first N members of the Fibonacci sequence.");
            Console.Write("N: ");
            int numberF = int.Parse(Console.ReadLine());
            int number1 = 0;
            int number2 = 1;            
            int nextNumber = 1;            
            int sumOfFibonacci = 1;
            if (numberF <= 1)
            {
                Console.WriteLine($"Entered number {numberF} <= 1!");
            }
            else
            {
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
            }
            EndOfScript();

            //6.Write a program that calculates N!/ K! for given N and K(1 < K < N).
            Console.WriteLine("EX6: Enter two integers N and K where (1 < K < N) and I will calculate N! / K!.");
            Console.Write("Enter N: ");
            //added a reference to System.Numerics assembly in the project
            //then added using System.Numerics to use BigInteger class
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (int i = (k + 1); i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine("The result for {0}! / {1}! is {2:E8}",n,k,result);
            EndOfScript();

            //7.Write a program that calculates N!*K!/ (N - K)! for given N and K
            //(1 < K < N).
            Console.WriteLine("EX7: Enter two integers N and K where (1 < K < N) and I will calculate N! * K! / (N - K)!.");
            Console.Write("Enter N: ");            
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int k1 = int.Parse(Console.ReadLine());
            BigInteger result1 = 1;
            int nMinusK = n1 - k1;
            //calculate N! / (N - K)!
            for (int i = (nMinusK + 1); i <= n1; i++)
            {
                result1 *= i;
            }
            //multiply N! / (N - K)! by K!
            for (int i = 1; i <= k1; i++)
            {
                result1 *= i;
            }
            Console.WriteLine("The result for {0}! * {1}! / ({0} - {1})! is {2:E3}", n1, k1, result1);
            EndOfScript();

            //8.In combinatorics, the Catalan numbers are calculated by the following
            //formula: 
            //(2n)! / ((n + 1)! * n!),
            //for n ≥ 0. Write a program that calculates the n-th Catalan number by given n.
            Console.WriteLine("EX8: Enter number N => 0 and I will calculate n-th Catalan number (2 * n)! / ((n + 1)! * n!).");
            Console.Write("N: ");
            int nCatalan = int.Parse(Console.ReadLine());
            BigInteger nCatalanResult = Factorial(2 * nCatalan) / (Factorial(nCatalan + 1) * Factorial(nCatalan));
            Console.WriteLine("Result for n-th Catalan number (2 * {0}!) / (({0} + 1)! * {0}!) = {1:E6}", nCatalan, nCatalanResult);

            EndOfScript();
            //9.Write a program that for a given integers n and x, calculates the sum: 
            //S = 1 + (1! / x) + (2! / x^2) + ... + (n! / x^n)             

            //10.Write a program that reads from the console a positive integer number
            //N € (1 .. 19) and prints a matrix of numbers as on the figures below: 
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
            Console.Write("EX10: Enter number N from (1 .. 19). I will return a matrix: ");
            int intMatrix = int.Parse(Console.ReadLine());
            if (intMatrix > 0 && intMatrix < 20)
            {
                for (int i = 1; i <= intMatrix; i++)
                {
                    for (int j = i; j < (intMatrix + i); j++)
                    {
                        if (j > 9)
                        {
                            Console.Write($"{j} ");
                        }
                        else
                        {
                            Console.Write($"{j}  ");
                        }

                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"The number you entered is out of def N from (1 .. 19)." +
                    $" Entered integet {intMatrix} " + (intMatrix > 19 ? "is greater then 19." : "is lower then 1."));
            }            
            EndOfScript();

            //11.Write a program that calculates with how many zeroes the factorial of
            //a given number ends.Examples: 
            //N = 10 -> N! = 3628800-> 2
            //N = 20 -> N! = 2432902008176640000-> 4
            Console.Write("EX11: Enter integer N. I will return a number of the zeros N! ends: ");
            int nNumber = int.Parse(Console.ReadLine());
            BigInteger nFactorial = Factorial(nNumber);
            BigInteger nFactorialTmp = nFactorial;
            int numberOfZeros = 0;
            while (nFactorialTmp % 10 == 0)
            {
                nFactorialTmp = nFactorialTmp / 10;
                numberOfZeros += 1;
            }
            switch (numberOfZeros)
            {
                case 0:
                    Console.WriteLine("The factorial of {0} ({1}) has not zeros.", nNumber, nFactorial);
                    break;
                case 1:
                    Console.WriteLine("The factorial of {0} ({1}) has 1 zero.", nNumber, nFactorial);
                    break;
                default:
                    Console.WriteLine("The factorial of {0} ({1}) has {2} zeros.", nNumber, nFactorial, numberOfZeros);
                    break;
            }
            EndOfScript();

            //12.Write a program that converts a given number from decimal to binary
            //notation(numeral system).
            Console.WriteLine("EX12: Convert positive integer N to binary");
            Console.Write("Enter positive integer: ");            
            uint numberConsole = uint.Parse(Console.ReadLine());            
            uint numberTmp = numberConsole;
            string numberDecimal = "";
            string numberBinary = "";
            while (numberTmp > 0)
            {
                numberDecimal += numberTmp % 2;
                numberTmp = numberTmp / 2;
            }

            char[] arrayDecimal = numberDecimal.ToCharArray();

            if (arrayDecimal.Length % 4 != 0)
            {
                for (int i = 0; i < ((((arrayDecimal.Length / 4) + 1) * 4) - arrayDecimal.Length); i++)
                {
                    numberBinary += "0";                    
                }
            }
            
            for (int i = arrayDecimal.Length - 1; i >= 0; i--)
            {
                numberBinary += arrayDecimal[i];                
                if (i % 4 == 0)
                {
                    numberBinary += " ";                    
                }
            }         
            Console.WriteLine(numberBinary);
            
            EndOfScript();

            //13.Write a program that converts a given number from binary to decimal
            //notation.
            Console.WriteLine("EX13: Convert binary number to decimal");
            Console.Write("Enter binary number: ");
            string numberBinary1 = Console.ReadLine();            
            uint numberDecimal1 = 0;
            int intExponent = numberBinary1.Length - 1;
            for (int i = 0; i < numberBinary1.Length; i++)
            {
                if (numberBinary1.Substring(i, 1) == "1")
                {
                    numberDecimal1 = numberDecimal1 + (uint)Math.Pow(2, intExponent);
                }
                intExponent--;
            }
            Console.WriteLine(numberDecimal1);
            EndOfScript();

            //14.Write a program that converts a given number from decimal to
            //hexadecimal notation.
            Console.WriteLine("EX14: Convert positive integer N to hexa");
            Console.Write("Enter positive integer: ");
            uint consoleUint = uint.Parse(Console.ReadLine());            
            string resultHexaNumberString = "";
            string resultHexa = "";
            while (consoleUint > 0)
            {                
                switch (consoleUint % 16)
                {
                    case 10:
                        resultHexaNumberString += "A";
                        break;
                    case 11:
                        resultHexaNumberString += "B";
                        break;
                    case 12:
                        resultHexaNumberString += "C";
                        break;
                    case 13:
                        resultHexaNumberString += "D";
                        break;
                    case 14:
                        resultHexaNumberString += "E";
                        break;
                    case 15:
                        resultHexaNumberString += "F";
                        break;
                    default:
                        resultHexaNumberString += consoleUint % 16;
                        break;
                }
                consoleUint = consoleUint / 16;
            }
            char[] resultCharArray = resultHexaNumberString.ToCharArray();
            for (int i = resultCharArray.Length - 1; i >= 0; i--)
            {
                resultHexa += resultCharArray[i];
            }
            Console.WriteLine(resultHexa);

            EndOfScript();

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
        public static void EndOfScript()
        {
            Console.WriteLine(new String('#', 60));
            Console.WriteLine();
        }
        public static BigInteger Factorial(int number)
        {
            BigInteger result = 1;
            while (number > 0 && number != 1)
            {
                result *= number;
                number--;
            }
            return result;
        }

    }
}
