using System;

delegate Even evendelegate (Even e);
class Even
{
    int evenNumber;
    public Even(int evenNumber)
    {
        this.evenNumber = evenNumber;
    }

    public static Even operator++(Even e)
    {
        e.evenNumber += 2;
        return e;
    }
    public static Even operator--(Even e)
    {
        e.evenNumber -= 2;
        return e;
    }
    public Even Getevenup(Even e)
    {
        e.evenNumber += 1;
        return e;
    }
}

namespace Practice_Note // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Even main = new Even(1);
            evendelegate fk = new evendelegate(main.Getevenup);
            Console.Write(fk(main));
        }
    }
}