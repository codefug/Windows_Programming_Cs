using System;

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
            Console.WriteLine("Hello, {0}!", args[0]); // Hello, World World를 프롬프트에 출력
        } 
    } 
}