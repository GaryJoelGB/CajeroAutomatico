using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CajeroAutomatico.Models;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    public class ATM
    {

        PropertiesATM transactions = new PropertiesATM();
        PersonInf PersonInf = new PersonInf();
        public void MethodInformation()
        {
            Console.Clear();
            Console.WriteLine($"Buenos dia señor {PersonInf.NameCompleted}");
            Console.WriteLine("Elige una de estas opciones:");
            Console.WriteLine();
            Console.WriteLine("1: Obtener monto");
            Console.WriteLine("2: Retirar monto");
            Console.WriteLine("3: Ver movimiento");
            Console.WriteLine("4: Salir");

            int options = int.Parse(Console.ReadLine());

            switch (options)
            {
                case 1:
                    GetAmount();
                    break;

                case 2:
                    WithdrawAmount();
                    break;

                case 3:
                    WatchMovement();
                    break;

                case 4:
                    Console.WriteLine("Saliendo..");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Numero incorrecto, elija otra vez");
                    Console.ReadKey();
                    MethodInformation();
                    break;

            }



        }

        public void GetAmount()
        {
            Console.Clear();
            Console.WriteLine("Su monto en la actualidad es de: " + transactions.AmountTotal);
            Console.WriteLine("Opcion 1: Devolver");
            Console.WriteLine("Opcion 2: Salir");
            int Option = int.Parse(Console.ReadLine());

            if(Option == 1)
            {
                MethodInformation();
            }
            else
            {
                Console.WriteLine("Adios...");
                Console.ReadKey();
               


            }


        }
        public void WithdrawAmount()
        {
            Console.Clear();
            Console.WriteLine("Cuanto deseas retirar");
            transactions.Withdrawal = decimal.Parse(Console.ReadLine());

            if(transactions.Withdrawal < transactions.Amount)
            {
                transactions.Amount -= transactions.Withdrawal;
                
                Console.WriteLine("Monto retirado: " + transactions.Withdrawal);
                Console.WriteLine("Opcion 1: Devolver");
                Console.WriteLine("Opcion 2: Salir");
                int Option = int.Parse(Console.ReadLine());
                transactions.MovemTransactions.Add(transactions.Withdrawal);
                transactions.HourTime.Add(DateTime.Now);

                if (Option == 1)
                {
                    MethodInformation();
                }
                else
                {
                    Console.WriteLine("Adios...");
                    Console.ReadKey();



                }

            }
            else
            {
                Console.WriteLine("Monto muy alto para su balance.");
                Console.WriteLine("Opcion 1: Devolver");
                Console.WriteLine("Opcion 2: Salir");
                int Option = int.Parse(Console.ReadLine());

                if (Option == 1)
                {
                    MethodInformation();
                }
                else
                {
                    Console.WriteLine("Adios...");
                    Console.ReadKey();



                }

            }


        }
        public void WatchMovement()
        {

            Console.Clear();
            for(int i = 0; i <  transactions.MovemTransactions.Count; i++)
            {
                Console.WriteLine("Nombre: " + PersonInf.FirstName);
                Console.WriteLine("Apellido: " + PersonInf.LastName);
                Console.WriteLine("Movimiento de dinero: " + transactions.MovemTransactions[i]);
                Console.WriteLine("Hora: " + transactions.HourTime[i]);
                Console.WriteLine();

            }


            Console.WriteLine("Opcion 1: Devolver");
            Console.WriteLine("Opcion 2: Salir");
            int Option = int.Parse(Console.ReadLine());

            if (Option == 1)
            {
                MethodInformation();
            }
            else
            {
                Console.WriteLine("Adios...");
                Console.ReadKey();



            }


        }


    }
}
