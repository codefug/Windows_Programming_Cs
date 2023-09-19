// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pernumlist = new List<int>();
            for (int number = 1; number < 501; number++) {
                int sum = 0;
                for (int i = 1; i <number; i++)
                {
                    if (number % i == 0) sum+=i;
                }
                if (number==sum) pernumlist.Add(number);
            }
            foreach(int number in pernumlist) { Console.Write(number+" "); }
        }
    }
}