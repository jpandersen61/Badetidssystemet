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

        }
    }
}
