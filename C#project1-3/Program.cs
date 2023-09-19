// See https://aka.ms/new-console-template for more information
using System;

namespace Cproject1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pnlist = new List<int>();
            for (int i = 0; i < 101; i++)
            {
                pnlist.Add(i);
            }
            for (int i = 2; i < 50; i++)
            {
                for (int j = i; j < 50; j++)
                {
                    if (i * j > 100)
                    {
                        break;
                    }
                    else
                    {
                        pnlist[i * j] = 0;
                    }
                }
            }
            for (int i = 2; i < 101; i++)
            {
                if (pnlist[i] !=0)
                {
                    Console.Write(pnlist[i]+" ");
                }
            }
        }
    }
}