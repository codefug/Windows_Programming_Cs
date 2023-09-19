// See https://aka.ms/new-console-template for more informationusing System;

using System.ComponentModel.Design;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean flag = true;
            String number = Console.ReadLine();
            for (int i = 0;i<number.Length/2;i++)
            {
                if (number[i] != number[number.Length-i-1]) { Console.WriteLine("False");
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("True");
            }
        }
    }
}