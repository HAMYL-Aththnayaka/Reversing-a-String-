using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)

        /* ask a user to input Mesage
         * print in order
         * print in reverse*/

        {
            Console.Write("Enter your Message: ");
            string message = Console.ReadLine();


          
            Console.WriteLine("The Message Length is : "+message.Length);
            Console.WriteLine();

            for (int i = 0; i < message.Length;  i++)
            {
                Console.Write(message[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Reverse :");
            Console.WriteLine();


            for (int i = message.Length-1; i > -1 ; i--)
            {
                Console.Write(message[i]);
            }

            Console.ReadKey();
        }
    }
}
