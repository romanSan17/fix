using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fix
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Random random = new Random();
            int N = random.Next(-100, 101);
            int M = random.Next(-100, 101);
            int[] arvud;

            if (N > M) 
            {
                arvud = Funktsioonid.Arvude_massiv(N, M); 
            }
            else 
            { 
                arvud = Funktsioonid.Arvude_massiv(N, M); 
            }
            foreach (int item in arvud) 
            {
                Console.WriteLine(item*item);
            }

                //for (int i = 0; i < -100; i++)
                //{
                //    Random random = new Random();
                //    int numb = random.Next(-100, 100);
                //} 









            //    string[] nimed = new string[5] { "Anna", "Inna", "Oksana", "Pavel", "Karl" };
            //for (int i = 0; i < nimed.Length; i++)
            //{
            //    Console.WriteLine(nimed[i]);
            //}
            //foreach (string nimi in nimed)
            //{
            //    Console.WriteLine(nimi);
            //}
            ////3.V
            //int n = 0;
            //while (n < nimed.Length)
            //{
            //    Console.WriteLine();
            //    n++;
            //}
            ////4.V
            //do
            //{
            //    Console.WriteLine(nimed[n - 1]);
            //    n--;
            //} while (n < 0);
        }
    }
}