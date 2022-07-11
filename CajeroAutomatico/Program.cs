using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CajeroAutomatico.Models;

namespace CajeroAutomatico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM aTM = new ATM();
            PropertiesATM transaction = new PropertiesATM();

            int trys = 3;

            
            for(int i = -1; i < transaction.Try; i++)
            {
                Console.Clear();
                Console.WriteLine("Bienvenido al cajero automatico Popular");
                Console.WriteLine("Digite los 4 digito de su cuenta bancaria");

                int Numero = int.Parse(Console.ReadLine());

                if (Numero == transaction.Key)
                {
                    aTM.MethodInformation();
                    transaction.Try++;


                }
                else
                {
                    Console.WriteLine($"Vuelve intentarlo, tienes {trys--} para volverlo hacer.");
                }

                Console.ReadKey();
                
            }

        }
    }
}
