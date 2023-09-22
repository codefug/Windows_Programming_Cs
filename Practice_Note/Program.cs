using System;

delegate even Getevenup (even e);
class even
{
    int evenNumber;
    public static even operator++(even e)
    {
        e.evenNumber += 2;
        return e;
    }
    public even Getevenup(even e)
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
            even Fake = new even();
            Getevenup fk = new Getevenup(Fake.Getevenup);
            fk(Fake);
        }
    }
}