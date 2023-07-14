using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elefantes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numElefantes, elefantes, setIncomoda;

            Console.WriteLine("Digite o número de elefantes: ");
            numElefantes = int.Parse(Console.ReadLine());

            for (elefantes = 1; elefantes <= numElefantes; elefantes++)
            {
                if (elefantes % 2 != 0)
                {
                    if (elefantes == 1)
                    {
                        Console.WriteLine($"\n{elefantes} elefante incomoda muita gente!");
                    }
                    else
                    {
                        Console.WriteLine($"{elefantes} elefantes incomodam muita gente!");
                    }
                }
                else if (elefantes % 2 == 0)
                {
                    Console.Write($"{elefantes} elefantes ");
                    setIncomoda = 1;
                    while (setIncomoda <= elefantes)
                    {
                        Console.Write("incomodam, ");
                        setIncomoda++;
                    }
                    Console.WriteLine("muito mais!");
                }
            }

            Console.ReadKey();

        }
    }
}
