using System;
using System.Collections.Generic;

namespace lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение факториала");
            int x;
            do
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x < 1)
                    Console.WriteLine("Факториал не может быть меньше 1\nВведите ещё раз.");
                else
                    break;
            } while (x < 1);


            List<int> KolX = new List<int>();
            List<int> KolFuct = new List<int>();
            Factorial(x, ref KolX, ref KolFuct);

            int KolAllX = 0;
            int MaxChisloX = 0;
            MaxX(KolX, ref KolAllX, ref MaxChisloX);

            int KolAllFuct = 0;
            int MaxChisloFuct = 0;
            MaxFuct(KolFuct, ref KolAllFuct, ref MaxChisloFuct);

            Tablet(KolX, KolFuct, KolAllX, KolAllFuct, MaxChisloX, MaxChisloFuct);

        }

        public static void Factorial(int x, ref List<int> KolX, ref List<int> KolFuct)
        {
            int fuct = 1;
            for (int i = 1; i <= x; i++)
            {
                fuct = fuct * i;
                KolX.Add(i);
                KolFuct.Add(fuct);
            }
        }

        public static void MaxX (List<int> KolX, ref int KolAllX, ref int MaxChisloX)
        {
            
            foreach (int i in KolX)
                KolAllX++;

            for (int i = 0; i < KolAllX; i++)
            {
                if (i > 0)
                {
                    if (KolX[i].ToString().Length > KolX[i - 1].ToString().Length)
                    {
                        MaxChisloX = 0;
                        MaxChisloX += KolX[i].ToString().Length;

                    }
                }
            }
            
        }

        public static void MaxFuct(List <int> KolFuct, ref int KolAllFuct, ref int MaxChisloFuct)
        {
            foreach (int i in KolFuct)
                KolAllFuct++;

            for (int i = 0; i < KolAllFuct; i++)
            {
                if (i > 0)
                {
                    if (KolFuct[i].ToString().Length > KolFuct[i - 1].ToString().Length)
                    {
                        MaxChisloFuct = 0;
                        MaxChisloFuct += KolFuct[i].ToString().Length;

                    }
                }
            }
            
        }

        public static void Raznost(int MaxChislo, List<int> Kol, int KolAll, ref int RaznAll, int TT)
        {
            RaznAll = 0;
            RaznAll = MaxChislo - TT;


        }
        public static void Tablet (List<int> KolX, List <int> KolFuct, int KolAllX, int KolAllFuct, int MaxChisloX, int MaxChisloFuct)
        {
            int TT = 0;
            int RaznAllX = 0;
            
            int RaznAllFuct = 0;
            
            for (int i = 0; i < KolAllX; i++)
            {
                TT = KolX[i];
                Console.Write("| ");
                for (int n = 0; n < TT; n++)
                {
                    Raznost(MaxChisloX, KolX, KolAllX, ref RaznAllX, TT);
                    Console.Write(" ");
                }
                Console.Write(KolX[i]);
                

                TT = KolFuct[i];
                Console.Write(" | ");
                for (int n = 0; n < TT; n++)
                {
                    Raznost(MaxChisloFuct, KolFuct, KolAllFuct, ref RaznAllFuct, TT);
                    Console.Write(" ");

                }
                Console.Write(KolFuct[i]);
                
                Console.WriteLine(" |");
            }

        }

    }
}
