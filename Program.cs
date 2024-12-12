using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Fibonacci_Sequence_Calculator
{
    internal class Program
    {
        static BigInteger fibonacciFirst = 0, fibonacciSecond = 1, fibonacciResult = 0, girilenBasamak;
        static bool girisDogruMu = false, devamEt = true;
        static string formattedResult;
        static void Main(string[] args)
        {

            while (devamEt)
            {
                Console.Title = "Fibonacci";
                appTR();
            }
        }

        static void appTR()
        {
            while (!girisDogruMu)
            {
                Console.Write("Fibonacci Serisi Hesaplayıcı - github.com/ebakc\n\n");
                Console.Write("Fibonacci dizisinde, bulmak istediğiniz basamak değerini(Fn) giriniz.( Basamak aralığı [1,Sonsuz] )\n");
                Console.Write("------------------------------------------------------------------------------------------------\n");
                Console.Write("Basamak(Fn) = ");
                try
                {
                    girilenBasamak = BigInteger.Parse(Console.ReadLine());
                    if (girilenBasamak <= 0)
                    {
                        girisDogruMu = false;
                        Console.Write("\n------------------------------------------------------------------------------------------------\n");
                        Console.Write("Geçersiz giriş. Sayı pozitif olmalıdır.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        girisDogruMu = true;
                        appHesap();
                        Console.Clear();

                    }
                }
                catch
                {
                    girisDogruMu = false;
                    Console.Write("\n------------------------------------------------------------------------------------------------\n");
                    Console.Write("Geçersiz giriş. Lütfen bir sayı giriniz.\n");
                    Console.ReadKey();
                    Console.Clear();
                }
                
                // 999.999.999.999.999 (999 Trilyon) sonucundan fazla olursa bilimsel gösterim ile gösterilecek.
                if (fibonacciResult >= 999999999999999)
                {
                    formattedResult = $"{fibonacciResult:E}";
                }
                else
                {
                    formattedResult = $"{fibonacciResult.ToString("N0")}";
                }
                
                Console.Write($"Fibonacci Serisi Hesaplayıcı - github.com/ebakc\n\nSeçtiğiniz Basamak: {girilenBasamak}\nSonuç: {formattedResult}\nBaşka bir hesaplama yapmak ister misiniz? (E/H): ");
                string cevap = Console.ReadLine().Trim().ToUpper();
                if (cevap != "E")
                {
                    devamEt = false;
                    Console.Clear();
                }
                else
                {
                    fibonacciResult = 0;
                    fibonacciFirst = 0;
                    fibonacciSecond = 1;
                    girisDogruMu = false;
                    Console.Clear();
                }
            }
        }
        static void appHesap()
        {
            if (girilenBasamak == 1 || girilenBasamak == 2)
            {
                fibonacciResult = 1;
            }
            else
            {
                for (int i = 2; i <= girilenBasamak; i++)
                {
                    fibonacciResult = fibonacciFirst + fibonacciSecond;
                    fibonacciFirst = fibonacciSecond;
                    fibonacciSecond = fibonacciResult;
                }
            }
        }
    }
}
