using System;

namespace ExLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            //Ex5();
            //Ex6();
            //Ex7();
            Ex9();
        }
        // Scrieti un proram care sa calculeze maximul a trei numere citite de la tastatura
        static void Ex1()
        {
            Console.WriteLine("Introduceti cele trei numere: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int Max = Math.Max(a, Math.Max(b, c));

            Console.WriteLine("Maximul celor trei numere este: " + Max);
        }
        //Scrieti un program care va citi de la tastatura un numar intreg pozitiv si va afisa valoarea acestuia in baza 2
        static void Ex2()
        {
            Console.WriteLine("Introduceti un numar natural: ");
            int a = int.Parse(Console.ReadLine());
            
            if(a>=0)
            {
                string Binary = Convert.ToString(a, 2);
                Console.WriteLine(a + " in baza 2 este: " + Binary);
            }
            else
            {
                Console.WriteLine("Ati introdus o valoare incorrecta.");
            }
        }
        //Scrieti un program care determina daca un numar "n" citit de la tastatura este un patrat perfect
        static void Ex3()
        {
            Console.WriteLine("Introduceti un numar natural: ");
            int a = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine(a + " este patrat perfect. ");
            }
            else if(a>0)
            {
                double radacinaPatrata = Math.Sqrt(a);
                bool estePatratPerfect = radacinaPatrata % 1 == 0;

                if (estePatratPerfect)
                {
                    Console.WriteLine(a + " este patrat perfect. ");
                }
                else
                {
                    Console.WriteLine(a + " nu este patrat perfect. ");
                }
            }
            else
            {
                Console.WriteLine("Ati introdus o valoare incorrecta.");
            }
        }
        // Se citesc numere de la tastatura pana la aparitia lui zero. Sa se detrmine suma lor.
        static void Ex4()
        {
            int counter = 1;
            int sumaNumerelor = 0;
            Console.WriteLine("Introduceti numere de la tastatura: ");

            while (counter == 1)
            {
                int a = int.Parse(Console.ReadLine());
                if (a != 0)
                {
                    sumaNumerelor += a;
                }
                else
                {
                    counter = 0;
                }
            }
            Console.WriteLine("Suma numerelor citite de la tastatura este: " + sumaNumerelor);
        }
        //Se citesc numere de la tastatura pana cand se introduc doua numere consecutive egale. Se va afisa suma lor.
        static void Ex5()
        {
            int counter = 1;
            Console.WriteLine("Introduceti numere de la tastatura: ");
            int ultimulNumarCitit = int.Parse(Console.ReadLine());
            int sumaNumerelor = ultimulNumarCitit;

            while (counter == 1)
            {
                int a = int.Parse(Console.ReadLine());
                if (a!=ultimulNumarCitit)
                {
                    sumaNumerelor += a;
                    ultimulNumarCitit = a;
                }
                else
                {
                    counter = 0;
                }
            }
            Console.WriteLine("Suma numerelor citite de la tastatura este: " + sumaNumerelor);
        }
        /*Scrieti un program care va determina daca un numar "n" citit de la tastatura este sau nu numar prim. Daca este prim, va
          afisa "prim", in caz contrar, va afisa numarul cu care este divizibil.*/
        static void Ex6()
        {
            Console.WriteLine("Introduceti un numar de la tastatura: ");
            int a = int.Parse(Console.ReadLine());
            int counter = 0;
            int i;

            for (i = 2; i < a && counter==0; i++)
            {
                if (a % i == 0)
                {
                    Console.WriteLine(a + " nu este prim, este divizibl cu " + i);
                    counter++;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine(a + " este prim.");
            }
        }
        //Scrieti un program care va citi doua numere de la tastatura si va calcula cel mai mare divizor comun al celor doua numere.
        static void Ex7()
        {
            Console.WriteLine("Introduceti cele doua numere de la tastatura: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            Console.WriteLine("Cel mai mare divizor comun al celor doua numere este: " + a);
        }
        //Scrieti un program care va citi de la tastatura lungimea si latimea unui dreptunghi si va afisa valoarea diagonalei acestuia.
        static void Ex9()
        {
            Console.WriteLine("Introduceti lungimea dreptunghiului: ");
            int lungime = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti latimea dreptunghiului: ");
            int latime = int.Parse(Console.ReadLine());

            Console.WriteLine("Diagonala dreptugiului este: "+CalculeazaDiagonalaDreptunghiului(lungime, latime).ToString("f2"));
        }
        /// <summary>
        /// Returneaza diagonala dreptunghiului
        /// </summary>
        /// <param name="a">lungimea</param>
        /// <param name="b">latimea</param>
        /// <returns>Valoarea diaonalei dreptunghiului</returns>
        static double CalculeazaDiagonalaDreptunghiului(int a, int b)
        {
            var diagonala = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));
            return diagonala;
        }
    }

}
