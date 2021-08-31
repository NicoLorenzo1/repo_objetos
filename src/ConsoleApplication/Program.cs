//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            var t = new Train("1");
            var t1 = new Train("Last Train To London");
            var t2 = new Train("Last Train To London");
            var t3 = new Train("Runaway Train");
            int contador = t.getCounter();

            //t.setID("1");
            //t.setCounter(5);

            while (contador < 10000000)
            {
                contador++;

            }
            t.setCounter(contador);
            //Console.WriteLine("Cantidad de instancias: " + t.getCounter());
            Console.WriteLine(t1 == t2);
            Console.WriteLine(t2 == t3);
            //t.StartEngines();
            //Console.WriteLine("Hello World!");
            //Console.WriteLine(Train.getCounter());
        }
    }
}