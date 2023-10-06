using System;
using System.Numerics;

namespace CsharpProject2_1// Note: actual namespace depends on the project name.
{
    class Fraction
    {
        private int numerator;
        private int denominator;
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denominator
        {
            get { return denominator; }
            set { denominator = value; }
        }
        public Fraction()
        {                   // 디폴트 생성자
            numerator = 0;
            denominator = 1;
        }
        public Fraction(int n)
        {              // 생성자
            numerator = n;
            denominator = 1;
        }
        public Fraction(int n, int d)
        {      // 생성자
            if (d < 0)
            {
                d = -d;
                n = -n;
            }
            numerator = n;
            denominator = d;
        }
        public override string ToString()
        {
            return (numerator + "/" + denominator);
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            Fraction answer = new Fraction();
            answer.Numerator=(a.Numerator*b.Denominator)+(b.Numerator*a.Denominator);
            answer.Denominator=a.Denominator*b.Denominator;
            return answer;
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            Fraction answer = new Fraction();
            answer.Numerator=(a.Numerator*b.Denominator)-(b.Numerator*a.Denominator);
            answer.Denominator = a.Denominator * b.Denominator;
            return answer;
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            Fraction answer = new Fraction();
            answer.Numerator = a.Numerator * b.Numerator;
            answer.Denominator = a.Denominator * b.Denominator;
            return answer;
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            Fraction answer = new Fraction();
            answer.Numerator = a.Numerator * b.Denominator;
            answer.Denominator = a.Denominator * b.Numerator;
            if (answer.Denominator < 0)
            {
                answer.Numerator = -answer.Numerator;
                answer.Denominator=-answer.Denominator;
            }
            return answer;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fraction first = new Fraction(1,-2);
            Fraction second =new Fraction(-1,-3);
            Console.WriteLine(first.ToString());
            Console.WriteLine(second);
            Console.WriteLine(first+second);
            Console.WriteLine(first-second);
            Console.WriteLine(first*second);
            Console.WriteLine(first/second);
        }
    }
}