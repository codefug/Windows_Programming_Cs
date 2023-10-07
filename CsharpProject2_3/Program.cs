using System;
using System.Drawing;

namespace CsharpProject2_3
{
    class Vector
    {
        private int[] v;
        public int size;
        // size는 할당받은 인덱서의 크기
        public Vector(int a)
        {
            v = new int[a];
            size = a;
        }
        public int this[int index]
        {
            get { return v[index]; }
            set { v[index] = value; }
        }
        public static Vector operator ++(Vector v)
        {
            for (int i=0;i<v.size;i++)
            {
                v[i] += 1;
            }
            return v;
        }
        public static Vector operator --(Vector v)
        {
            for (int i = 0; i < v.size; i++)
            {
                v[i] -= 1;
            }
            return v;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Vector a = new Vector(5);
            a[0] = 1;
            a[1] = 3;
            Console.WriteLine("초기화된 인덱서");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(a[i]+" ");
            }
            a++;
            Console.WriteLine("\na++ 이후의 인덱서");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(a[i]+" ");
            }
            a--;
            Console.WriteLine("\na-- 이후의 인덱서");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(a[i]+" ");
            }

        }
    }
}