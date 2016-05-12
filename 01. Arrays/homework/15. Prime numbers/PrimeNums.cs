﻿/*  Problem 15. Prime numbers
    Write a program that finds all prime numbers in the range [1 ... N]. 
    Use the Sieve of Eratosthenes algorithm. 
    The program should print the biggest prime number which is <= N.
    Input: On the first line you will receive the number N
    Output: Print the biggest prime number which is <= N
    Constraints: 2 <= N <= 10 000 000
 */

using System;

class SieveOfEratosthenes
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool[] primes = new bool[n + 1];

        for (int i = 2; i < Math.Sqrt(primes.Length); i++)
        {
            if (primes[i] == false)
            {
                for (int j = i * i; j < primes.Length; j+=i)
                {
                    primes[j] = true;
                }
            }
        }

        for (int i = primes.Length-1; i >= 2; i--)
        {
            if (!primes[i])
            {
                Console.WriteLine(i);
                break;
            }
        }
        

    }
}