using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CancelarToken
{
    class Program
    {
        static int acumulador = 0;
        static void Main(string[] args)
        {
                
            CancellationTokenSource miToken= new CancellationTokenSource();
            CancellationToken cancelator=miToken.Token;

            Task tarea = Task.Run(() => RealizarTarea(cancelator));

            for (int i = 0; i < 100; i++)
            {
                acumulador += 30;
                Thread.Sleep(1000);
                if (acumulador > 100)
                {
                    miToken.Cancel();
                    break;
                }
            }
            Thread.Sleep(1000);
            Console.WriteLine("Valor del acumulador es " + acumulador);
            Console.ReadLine();
        }

        static void RealizarTarea(CancellationToken token) 
        {
            for (int i = 0; i < 100; i++)
            {
                acumulador ++;
                var miThread = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(1000);
                Console.WriteLine("Ejecutando tarea en Thread"+ miThread.ToString());
                Console.WriteLine(acumulador);
                if (token.IsCancellationRequested)
                {
                    acumulador = 0;
                    return;
                }
            }
        }
    }
}
