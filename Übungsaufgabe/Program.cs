using System;

namespace Übungsaufgabe
{
    class Program
    {
        class zahlenpaar
        {
            private int a;
            private int b;

            public zahlenpaar()                  // 1.Standartkonstruktor
            {
                a = 0;
                b = 0;
            }

            public zahlenpaar(int zahl1,int zahl2)      // Konstruktor dem Werte überbegebn können
            {
                a = zahl1;
                b = zahl2;
            }

            public zahlenpaar(string zahl)      // Konstruktor dem Werte überbegebn können im Stringformat
            {
                int indexofk1, indexofk2, indexofkom, zahla,zahlb;
                indexofk1 = zahl.IndexOf('(');
                indexofk2 = zahl.IndexOf(')');
                indexofkom = zahl.IndexOf(',');

                if (indexofkom == 2)
                {
                    zahla = zahl[1] - 48;
                }
                if (indexofkom == 3)
                {
                    zahla = ((zahl[1] - 48) * 10)+ (zahl[2] - 48);
                }

                if (zahl[indexofk2 - 2] == ',')
                {
                    zahlb = zahl[indexofkom + 1] - 48;
                }
                if (zahl[indexofk2 - 3] == ',')
                {
                    zahlb = ((zahl[indexofkom + 1] - 48)*10)+zahl[indexofkom+2];
                }
            }
            public static zahlenpaar operator +(zahlenpaar a1,zahlenpaar b1) 
            {
                zahlenpaar kekw2 = new zahlenpaar();
                kekw2.a = a1.a + b1.a;
                kekw2.b = a1.b + b1.b;
                if (kekw2.a > 98)
                    kekw2.a = 99;
                if (kekw2.b > 98)
                    kekw2.b = 99;
                return (kekw2);
            }
            public static bool operator <(zahlenpaar a1,zahlenpaar b1) 
            {
                int summea1 = a1.a + a1.b, summea2 = b1.a + b1.b;
                if (summea1 < summea2)
                    return true;
                else 
                    return false;
            }
            public static bool operator >(zahlenpaar a1, zahlenpaar b1)
            {
                int summea1 = a1.a + a1.b, summea2 = b1.a + b1.b;
                if (summea1 > summea2)
                    return true;
                else
                    return false;
            }
            public static bool operator ==(zahlenpaar a1, zahlenpaar b1)
            {
                int summea1 = a1.a + a1.b, summea2 = b1.a + b1.b;
                if (summea1 == summea2)
                    return true;
                else
                    return false;
            }
            public static bool operator !=(zahlenpaar a1, zahlenpaar b1)
            {
                int summea1 = a1.a + a1.b, summea2 = b1.a + b1.b;
                if (summea1 != summea2)
                    return true;
                else
                    return false;
            }

            public static void ausgabe()
            {
                Console.WriteLine("{0},{1}");
            }



        }
        static void Main(string[] args)
        {
            zahlenpaar kekw  = new zahlenpaar();
            zahlenpaar kekw2 = new zahlenpaar();
            Console.WriteLine("{0}",kekw+kekw2);
            if (kekw<kekw2)
            {
                Console.WriteLine("kekw");
            }
            if (kekw > kekw2)
            {
                Console.WriteLine("kekw");
            }
            if (kekw == kekw2)
            {
                Console.WriteLine("kekw");
            }
            if (kekw != kekw2)
            {
                Console.WriteLine("ungleich");
            }
        }
    }
}
