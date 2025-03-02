using System;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            numeros.Add(1);
            numeros.Add(1);
            numeros.Add(45);
            numeros.Add(8);
            numeros.Add(18);
            numeros.Add(101);
            numeros.Add(202);
            numeros.Add(123);

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

            numeros.Add(1000);

            //Console.WriteLine(numeros.Capacity);
            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros[i]);
            }



        }
    }
}
