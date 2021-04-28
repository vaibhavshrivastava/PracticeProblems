using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Threading
{
    //ForeGround thread :--> Executes even if the main application quits 

    //BackGround thread :--> Quits if main application quits
    class Programa
    {
        static void Main(string[] args)
        {

            ThreadSync tsync = new ThreadSync();
            tsync.Test();
        }

        static void Function1()
        {
            Console.WriteLine("Function 1 is Entering...");
            Console.ReadLine();
            Console.WriteLine("Function 1 is Exited...");
        }

        static void Function2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function2 is executed" + i.ToString());
                Thread.Sleep(4000);
            }
        }
    }
    // Thread syncronizatin 
    //--Lock
    //--Mutex
    //--Semaphore
}
