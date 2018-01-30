//This program will list all numbers between 1 and 100 that are divisable by 3.
using System;

namespace ConsoleApp3
{
    class DivisableBy3
    {
        static void Main(string[] args)
        {
            int count = 0;

            for (int i = 1; i <= 100; i++) {//Goes from 1 to 100 and for every number that evenly divdes by three, one is added to the count.
                if (i % 3 == 0) {
                    count++;
                }
            }
            Console.Write(count + "\n"); //This total of numbers divisable by 3 is presented at the end of the looping.
        }
    }
}
