using System;

namespace Badetidssystemet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opgave 1");
            Kreds k1 = new Kreds("K1", "Roskilde", "Maglegaardsvej 2, 4000 Roskilde", 25);
            Kreds k2 = new Kreds("K2", "København", "Rådhuspladsen 1, 1000 København", 100);
            Console.WriteLine(k1);
            Console.WriteLine(k2);

            Console.WriteLine("Opgave 2");
            BadetidsPeriode b1 = new BadetidsPeriode("Morgendukkert", DayOfWeek.Friday, new DateTime().AddHours(6), new DateTime().AddHours(8));
            BadetidsPeriode b2 = new BadetidsPeriode("Aftensvaler", DayOfWeek.Monday, new DateTime().AddHours(19), new DateTime().AddHours(21));
            Console.WriteLine(b1);
            Console.WriteLine(b2);
        }
    }
}
