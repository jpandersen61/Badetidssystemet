using System;

namespace Badetidssystemet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opgave 1");
            Kreds k1 = new Kreds("Kreds1", "Roskilde", "Maglegaardsvej 2, 4000 Roskilde", 25);
            Kreds k2 = new Kreds("Kreds2", "København", "Rådhuspladsen 1, 1000 København", 100);
            Console.WriteLine(k1);
            Console.WriteLine(k2);

            Console.WriteLine("Opgave 2");
            BadetidsPeriode b1 = new BadetidsPeriode("Morgendukkert", DayOfWeek.Friday, new DateTime().AddHours(6).AddMinutes(30), new DateTime().AddHours(8));
            BadetidsPeriode b2 = new BadetidsPeriode("Aftensvaler", DayOfWeek.Monday, new DateTime().AddHours(19), new DateTime().AddHours(21));
            Console.WriteLine(b1);
            Console.WriteLine();
            Console.WriteLine(b2);
            Console.WriteLine();

            Console.WriteLine("Opgave 4");
            b1.AdderKreds(k1);
            b1.AdderKreds(k2);
            b2.AdderKreds(k1);
            b2.AdderKreds(k2);
            Console.WriteLine();
            Console.WriteLine(b1);
            Console.WriteLine();
            Console.WriteLine(b2);
            Console.WriteLine();
            
            Console.WriteLine("Opgave 7 + 8");
            try
            {
                new Kreds("XXX", "QQQ", "GGG", (-42));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
            try
            {
                new BadetidsPeriode("Ingen dukkert", DayOfWeek.Friday, new DateTime().AddHours(1), new DateTime());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
            try
            {
                new BadetidsPeriode("", DayOfWeek.Friday, new DateTime(), new DateTime().AddHours(1));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    
}
