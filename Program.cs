using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Abecedario
{
    class Program
    {
        
            static void Main(string[] args)
        {
            //65 al 90
            Task tareaA = new Task(() =>
            {
                for (int i = 65; i < 91; i = i + 2)
                {
                    Console.WriteLine("{0} : id hilo {1}", (char)i, Thread.CurrentThread.ManagedThreadId);

                }

            });
           
            Task tareaB = new Task(() =>
            {
                for (int i = 66; i < 91; i = i + 2)
                {

                    Console.WriteLine("{0} : id hilo {1}", (char)i, Thread.CurrentThread.ManagedThreadId);
                }

            });
           
            
            tareaA.Start();
          
            tareaB.Start();
            Task.WaitAll(tareaA, tareaB);

            Console.ReadKey();



        }
    }
}
