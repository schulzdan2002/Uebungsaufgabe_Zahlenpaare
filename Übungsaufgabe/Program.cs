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

            public zahlenpaar(int zahl1,int zahl2)      // Konstruktor dem Werte überbegebn können als Integer
            {
                a = zahl1;
                b = zahl2;
            }

            public zahlenpaar(string zahl)      // Konstruktor dem Werte überbegebn können als String
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
            public static zahlenpaar operator +(zahlenpaar a1,zahlenpaar b1) // Additition von Zahlpaar 1 und Zahlenpaar 2
            {
                zahlenpaar z1 = new zahlenpaar();
                z1.a = a1.a + b1.a;
                z1.b = a1.b + b1.b;
                if (z1.a > 98)
                    z1.a = 99;
                if (z1.b > 98)
                    z1.b = 99;
                return (z1);
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

            public void ausgabe()
            {
                Console.WriteLine("{0},{1}",a,b);
            }



        }
        static void Main(string[] args)
        {
            zahlenpaar z1  = new zahlenpaar(2,4);
            zahlenpaar z2 = new zahlenpaar(0,5);
            (z1 + z2).ausgabe();
            if (z1<z2)
            {
                Console.WriteLine("z2 ist größer");
            }
            if (z1 > z2)
            {
                Console.WriteLine("z2 ist kleiner");
            }
            if (z1 == z2)
            {
                Console.WriteLine("gleich");
            }
            if (z1 != z2)
            {
                Console.WriteLine("ungleich");
            }
        }
    }
}
