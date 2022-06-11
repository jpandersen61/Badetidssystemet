using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    class Kreds
    {
        string _id;
        string _navn;
        string _adresse;
        int _antalDeltagare;

        public string ID 
        { 
            get { return _id; } 
            private set 
            {
                if (value.Length < 1)
                {
                    string errMsg = "ID må ikke være kortere end 1";
                    Console.WriteLine(errMsg);
                }
                else
                {
                    _id = value;
                }
            } 
        }
        public string Navn { get { return _navn; } private set { _navn = value; } }
        public string Adresse { get { return _adresse; } private set { _adresse = value; } }
        public int AntalDeltagere 
        { 
               get { return _antalDeltagare; } 
               private set 
               {
                   if (value < 0)
                   {
                       string errMsg = "Antal deltagere skal være større en 0";
                        
                       Console.WriteLine(errMsg);
                   }
                   else
                   {
                       _antalDeltagare = value;
                   }
               }  
        }

        public Kreds()
        {
            ID = "";
            Navn = "";
            Adresse = "";
            AntalDeltagere = 0;
        }

        public Kreds(string id, string navn, string adresse, int antalDeltagere)
        {
            ID = id;
            Navn = navn;
            Adresse = adresse;
            AntalDeltagere = antalDeltagere;
        }

        public override string ToString()
        {
            return $"ID:{ID}, Navn:{Navn}, Adresse:{Adresse}, Deltagere:{AntalDeltagere}";
        }
    }
}
