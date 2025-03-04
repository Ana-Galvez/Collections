using System;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////listas
            //List<int> numerosEnteros= new List<int>();
            //int dato;
            //Console.WriteLine("¿Cuántos números quieres guardar?");
            //dato=Int32.Parse(Console.ReadLine());
            //for (int i = 0; i < dato; i++)
            //{
            //    numerosEnteros.Add(Int32.Parse(Console.ReadLine()));
            //}
            //Console.WriteLine();
            //foreach (var item in numerosEnteros)
            //{
            //    Console.WriteLine(item);
            //}

            //List<string> list = new List<string>(3);
            //list.Add("a");
            //list.Add("a");

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //List<int> numeros = new List<int>();
            //numeros.Add(1);
            //numeros.Add(1);
            //numeros.Add(45);
            //numeros.Add(8);
            //numeros.Add(18);
            //numeros.Add(101);
            //numeros.Add(202);
            //numeros.Add(123);

            //foreach (var numero in numeros)
            //{
            //    Console.WriteLine(numero);
            //}

            //numeros.Add(1000);

            ////Console.WriteLine(numeros.Capacity);
            //for (int i = 0; i < numeros.Count; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}


            //Console.WriteLine();
            //int[] numerosArrays = { 4, 6, 2, 12, 3 };
            //List<int> otrosNumeros = new List<int>(numerosArrays);
            //otrosNumeros.Add(130);
            //for (int i = 0; i < otrosNumeros.Count; i++)
            //{
            //    Console.WriteLine(otrosNumeros[i]);
            //}
            //otrosNumeros.AddRange(numeros);
            //foreach (var item in otrosNumeros)
            //{
            //    Console.WriteLine(item);
            //}
            ////Fin listas
            //Inicio Linked List
            int[] numbersArrays = { 6, 8, 56, 12, 47 };
            LinkedList<int> numbers = new LinkedList<int>(numbersArrays);
            numbers.AddLast(123);
            numbers.AddFirst(456);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(numbers.Contains(123));
            LinkedListNode<int> nodo = numbers.First;
            for (nodo=numbers.First; nodo != null; nodo=nodo.Next)
            {
                Console.WriteLine(nodo.Value);
            }
            //Fin LinkedList

        }
    }
}
