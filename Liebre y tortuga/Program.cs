using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Liebre_y_tortuga
{
    class Program
    {
        public  static Random rnm = new Random();
        public static Random tiemp = new Random();
       
        static void Main(string[] args)
        {
            int distancia=5000;
            
            Thread t1 = new Thread(() => Liebre(distancia));
            Thread t2 = new Thread(Tortuga);
            t1.Priority = ThreadPriority.AboveNormal;
            t2.Priority = ThreadPriority.BelowNormal;

            t1.Start();
            t2.Start(distancia);
            Console.ReadKey();
        }

        static void Liebre(int d)
        {
             int rnm1 = rnm.Next(1,10 ); 
            int tiemp1 = tiemp.Next(100,500);
            Console.WriteLine(rnm1);
            Console.WriteLine(tiemp1);
            int i = 0;
            do
            {          
                    Console.Write("L");
                
               
                if (rnm1 <=5 )
                {
                    Console.Write("Liebre dormida");
                    Thread.Sleep(Convert.ToInt32(tiemp1));
                    Console.Write("Liebre despierta");
                    rnm1 = 6;
                }

                i++;
            } while (i<=d);
            Console.Write("Liebre llego a la meta ");
        }

        static void Tortuga(object d)
        {
            for (int i = 0; i <= Convert.ToInt32(d); i++)

            {
                Console.Write("T");
            }
            Console.Write("Tortuga llego a la meta ");
        }
    }
}
