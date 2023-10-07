using System;

namespace CsharpProject2_4
{
    class Date
    {
        public int[] Monthlist = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private int year, month, day, totalDays;
        
        // 각 프로퍼티
        public int Year
        {
            get { return year; } 
            set { year = value; }
        }
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        public int TotalDays
        {
            get { return totalDays; }
            set { totalDays = value; }
        }

        // 월 일을 받으면 totalDays를 갱신하는 메소드
        public void Makeittotal(int m,int d)
        {
            TotalDays = d;
            for (int i = 1; i < m; i++)
            {
                TotalDays += Monthlist[i];
            }
            return;
        }

        // total을 받으면 년,월,일을 계산하고 totalDays를 갱신하는 메소드
        public void Maketotalmonthday(int total)
        {
            // 0일때는 작년의 12월 31일이다.
            while (total <= 0)
            {
                Year -= 1;
                total += 365;
            }
            // 365일은 해당 연도의 12월 31일이다.
            while (total > 365)
            {
                Year += 1;
                total -= 365;
            }
            totalDays = total;
            for (int i = 1; i < 13; i++)
            {
                if (total - Monthlist[i] > 0)
                {
                    total -= Monthlist[i];
                }
                else
                {
                    Month = i;
                    Day = total;
                    break;
                }
            }
        }

        public Date(int y, int m, int d)
        {
            Year = y;
            Month = m;
            Day = d;
            Makeittotal(m,d);
            // 년 월 일은 정상범위의 수를 입력 받는다고 가정
        }

        public static Date operator +(Date a, int n)
        {
            Date answer = new Date(a.Year, a.Month, a.Day);
            answer.Maketotalmonthday(answer.TotalDays + n);
            return answer;
        }
        public static Date operator -(Date a, int n) {
            Date answer = new Date(a.Year, a.Month, a.Day);
            answer.Maketotalmonthday(answer.TotalDays - n);
            return answer;
        }
        public static bool operator ==(Date a, Date b)
        {
            return (a.totalDays==b.totalDays & a.Year==b.Year); 
        }public static bool operator !=(Date a, Date b)
        {
            return (a.totalDays != b.totalDays | a.Year != b.Year);
        }
        public static bool operator >(Date a, Date b)
        {
            return (a.Year > b.Year | (a.totalDays > b.totalDays & a.Year == b.Year));
        }public static bool operator <(Date a, Date b)
        {
            return (a.Year < b.Year | (a.totalDays < b.totalDays & a.Year == b.Year));
        }
        // 그냥 !로 구현하면 같은 경우도 들어가서 안됨.

        public static Date operator --(Date a)
        {
            Date answer = new Date(a.Year, a.Month, a.Day);
            answer.Maketotalmonthday(answer.TotalDays - 1);
            return answer;
        }
        
        public static Date operator ++(Date a)
        {
            Date answer = new Date(a.Year, a.Month, a.Day);
            answer.Maketotalmonthday(answer.TotalDays + 1);
            return answer;
        }

        public override string ToString()
        {
            return string.Format("{0:0000}/{1:00}/{2:00}", Year, Month, Day);
        }
    }
    class Program
    {
        static void Main()
        {
            Date date_a = new Date(2023, 10, 7);
            Date date_b = new Date(2022, 12, 31);
            Console.WriteLine("date_a = "+date_a);
            Console.WriteLine("date_b = "+date_b);
            Console.WriteLine("date_b+16 = "+ (date_b +16));
            Console.WriteLine("date_b-23 = "+(date_b -23));
            Console.WriteLine("++date_b = " + (++date_b));
            Console.WriteLine("--date_b = " + (--date_b));
            Console.WriteLine("date_a==date_b = " + (date_a == date_b));
            Console.WriteLine("date_a!=date_b = " + (date_a != date_b));
            Console.WriteLine("date_a>date_b = " + (date_a > date_b));
            Console.WriteLine("date_a<date_b = " + (date_a < date_b));
        }
    }
}