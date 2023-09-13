using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    class MainApp {
        // 프로그램 실행이 시작되는 곳
        static void Main(string[] args) {
            if (args.Length == 0)
            {
                Console.WriteLine("사용법: Hello.exe 이름");
                return;
            }
            double sum = 0;
            for (int i = 1; i < 7; i++) {
                sum += (1 / (Math.Pow(2,i)));
                Console.WriteLine(sum);
            }
            Console.WriteLine("Hello,dd {0}!", args[0]); // Hello, World World를 프롬프트에 출력
        }
    } 
}