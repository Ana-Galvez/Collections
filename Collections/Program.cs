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
            ////Inicio Linked List
            //int[] numbersArrays = { 6, 8, 56, 12, 47 };
            //LinkedList<int> numbers = new LinkedList<int>(numbersArrays);
            //numbers.AddLast(123);
            //numbers.AddFirst(456);
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(numbers.Contains(123));
            //LinkedListNode<int> nodo = numbers.First;
            //for (nodo=numbers.First; nodo != null; nodo=nodo.Next)
            //{
            //    Console.WriteLine(nodo.Value);
            //}
            //LinkedListNode<string> fruta1 = new LinkedListNode<string>("manzana");
            //Console.WriteLine(fruta1.Value);
            //LinkedList<string> frutas = new LinkedList<string>();
            //frutas.AddLast(fruta1);
            //Console.WriteLine(fruta1.List.Count);
            //frutas.AddFirst("naranja");
            //Console.WriteLine(fruta1.Previous.Value);
            //Console.WriteLine(fruta1.List.Count);
            //frutas.AddAfter(fruta1, "pera");
            //Console.WriteLine(fruta1.Next.Value);
            ////Fin LinkedList
            ////Inicio Queue
            //Queue<string> nombres = new Queue<string>();
            //nombres.Enqueue("Ana");
            //nombres.Enqueue("tatin");
            //nombres.Enqueue("juan");

            //foreach (string item in new string[3] {"Matías","Carmen","Yanina"})
            //{
            //    nombres.Enqueue(item);
            //}
            //foreach (string item in nombres)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(nombres.Count);
            //Console.WriteLine(nombres.Dequeue());
            //foreach (string item in nombres)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("peek");
            //Console.WriteLine(nombres.Peek());
            //Console.WriteLine(nombres.Contains("juan"));
            //string[] nombreArray = nombres.ToArray();
            //Console.WriteLine("array");
            //foreach (var item in nombreArray)
            //{
            //    Console.WriteLine(nombreArray.GetType());
            //}
            ////Fin queue
            ////Inicio Stack
            //Stack<int> numerosStack = new Stack<int>();
            //numerosStack.Push(0);
            //numerosStack.Push(0);
            //numerosStack.Push(0);
            //foreach (int item in new int[3] {6,12,8})
            //{
            //    numerosStack.Push(item);
            //}
            //foreach (var item in numerosStack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(numerosStack.Peek());
            //Console.WriteLine("El número borrado es: "+ numerosStack.Pop());
            ////Fin stack
            ////Inicio dictionary
            //Dictionary<string,int> empleados = new Dictionary<string,int>();
            //empleados.Add("ana", 50000);
            //empleados.Add("tatin", 35000);
            //empleados.Add("juan", 40000);

            //foreach (KeyValuePair<string,int> datos in empleados)
            //{
            //    Console.WriteLine("Nombre del empleado: " + datos.Key );
            //} 
            //foreach (KeyValuePair<string,int> datos in empleados)
            //{
            //    Console.WriteLine("Sueldo de " + datos.Key + ": " + datos.Value );
            //}
            //Console.WriteLine(empleados.Remove("juan"));
            //foreach (KeyValuePair<string, int> datos in empleados)
            //{
            //    Console.WriteLine("Sueldo de " + datos.Key + ": " + datos.Value);
            //}

            ////Fin dictionary
            ////Inicio HashSet
            //HashSet<int> evenNumbers = new HashSet<int>();
            //HashSet<int> oddNumbers = new HashSet<int>();
            //HashSet<int> ints = new HashSet<int>() { 5,6,9,88,77};
            //for(int i = 0;i<10;i++)
            //{
            //    evenNumbers.Add(i*2);
            //    oddNumbers.Add(i*2+1);
            //}
            //foreach (var item in oddNumbers)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in evenNumbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(evenNumbers.Count);
            //Console.WriteLine(oddNumbers.Count);
            //evenNumbers.Add(24);
            //evenNumbers.Add(104);
            //evenNumbers.Add(22);
            //Console.WriteLine();
            //foreach (var item in evenNumbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(evenNumbers.Contains(104));
            //evenNumbers.Remove(22);
            //evenNumbers.UnionWith(oddNumbers);
            //Console.WriteLine();
            //foreach (var item in evenNumbers)
            //{
            //    Console.WriteLine(item);
            //}
            ////Fin HashSet
            ////Inicio SortedSet: no acepta duplicado y ordena
            //int[] arraySorted = new int[] { 56, 8, 23, 54, 123, 56, 200 };
            //SortedSet<int> intsSorted = new SortedSet<int>() { 18,520,45,96};
            //SortedSet<int> list = new SortedSet<int>(arraySorted) ;
            //list.Add(100);
            //foreach (int item in list) Console.WriteLine(item);
            //Console.WriteLine(list.Min);
            //Console.WriteLine(list.Max);
            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.Contains(8));
            //foreach (int item in intsSorted) Console.WriteLine(item);
            //Console.WriteLine(intsSorted.Remove(18));
            //foreach (int item in intsSorted) Console.WriteLine(item);
            ////Fin SortedSet
            //Inicio SortedDictionary
            SortedDictionary<string,string> empleado=new SortedDictionary<string, string>();
            empleado.Add("Ana", "Hernandez");
            empleado.Add("Juan", "Gutierrez");
            empleado.Add("Mateo", "Gutierrez");
            empleado.Add("Gonzalo", "Gutierrez");
            foreach (KeyValuePair<string,string> kvp in empleado) 
            {
                Console.WriteLine("Nombre: {0}, Apellido: {1}",kvp.Key,kvp.Value);
            }
            //Fin SortedDictionary
        }
    }
}
