﻿using System;

namespace Problema04
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            try
            {
                Console.WriteLine("{0} - {1} - {2}", a, b);
            }
            catch (FormatException x)
            {
                Console.WriteLine($"\nError detectado: \n{x}");
            }
            finally
            {
                Console.WriteLine("\nPresione ENTER para finalizar");
                Console.ReadLine();
            }
        }
    }
}
