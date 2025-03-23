using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26n3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[] { 1, 2, 3, 4, 5 };
            Input(mass);
            Console.Read();

        }
        static void Input(int[] mass)
        {
            foreach (int i in mass)
            {
                Console.WriteLine(mass[0]);
                Console.WriteLine(mass[1]);
                Console.WriteLine(mass[2]);
                Console.WriteLine(mass[3]);
                Console.WriteLine(mass[4]);
                Console.Read();

            }
        }
    }

    }

