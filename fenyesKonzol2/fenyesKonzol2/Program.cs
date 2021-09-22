using System;
using System.Collections.Generic;
using System.IO;

namespace fenyesKonzol2
{

    class Program
    {
        class Feldolgoz
        {
            public DateTime datum;
            public string hely, fellepo, szinpad;
            public Feldolgoz(string s)
            {
                string[] db = s.Split(' ');             
                hely = db[0];
                fellepo = db[1];
                szinpad = db[2];
                datum = Convert.ToDateTime(db[3]);
            }
            

        }
        static void Main(string[] args)
        {
            List<Feldolgoz> adatok = new List<Feldolgoz>(); ;
            foreach (var i in File.ReadAllLines("adatok.txt"))
            {              
                adatok.Add(new Feldolgoz(i));
            }


            /*
             * 1. lekérdezés
             * 
             * 
             * 
             */
            Console.WriteLine("1) Adjon meg egy fellépőt: ");
            string be = Console.ReadLine();
            byte talalt = 0;
            foreach (var i in adatok)
            {
                if (i.fellepo == be)
                {
                    Console.WriteLine("\tFellépés adatai: "+i.hely+" | "+i.fellepo+" | "+i.szinpad+" | "+i.datum);
                    talalt = 1;
                }
            }
            if (talalt == 0) Console.WriteLine("\tNem találtam eseményt a megadott paraméterekkel");

            
            /*
             * 2. lekérdezés
             * 
             * 
             */

            talalt = 0;
            Console.WriteLine("2) Adjon meg egy dátumot és színpadot: ");
            Console.Write("Dátum: ");
            DateTime be_d = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Színpad: ");
            string be_sz = Console.ReadLine();
            foreach (var i in adatok)
            {
                if (be_d == i.datum && be_sz == i.szinpad)
                {
                    Console.WriteLine("\tFellépés adatai: " + i.hely + " | " + i.fellepo + " | " + i.szinpad + " | " + i.datum);
                    talalt = 1;
                }

            }
            if (talalt == 0) Console.WriteLine("\tNem találtam eseményt a megadott paraméterekkel");


            /*
             * 3. lekérdezés
             * 
             * 
             * 
             */

            talalt = 0;
            Console.WriteLine("3) Adjon meg egy helyszínt, megmondom, mikor volt ott esemény: ");
            string be_h = Console.ReadLine();
            foreach (var i in adatok)
            {
                if (be_h == i.hely)
                {
                    Console.WriteLine("\t"+i.datum);
                    talalt = 1;
                }
            }
            if (talalt == 0) Console.WriteLine("\tNem találtam eseményt a megadott paraméterekkel");
            Console.ReadKey();
        }
    }


}
