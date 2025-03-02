using System;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(3);
            list.Add("a");
            list.Add("a");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

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


            Console.WriteLine();
            int[] numerosArrays = { 4,6,2,12,3};
            List<int> otrosNumeros = new List<int>(numerosArrays);
            otrosNumeros.Add(130);
            for (int i = 0; i < otrosNumeros.Count; i++)
            {
                Console.WriteLine(otrosNumeros[i]);
            }
            otrosNumeros.AddRange(numeros);
            foreach (var item in otrosNumeros)
            {
                Console.WriteLine(item);
            }
        }
    }
}
