using Estrutura.CSharp.LinkedList;
using System;
using Estrutura.CSharp.Sort;

namespace Estrutura.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - LinkedList");
            Console.WriteLine("2 - BubbleSort");
            var inputOp = Console.ReadLine();
            switch (inputOp)
            {
                case "1":
                    ExecuteLinkedList();
                    break;
                case "2":
                    ExecuteBubbleSort();

                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }

        }

        private static void ExecuteBubbleSort()
        {
            int[] array = new int[10];
            var random = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(1, 100);
            Console.WriteLine("Print all numbers array");
            foreach (var item in array)
                Console.WriteLine($"{item}");

            Console.WriteLine("Print all numbers sorted array");
            foreach (var item in array.Sort())
                Console.WriteLine($"{item}");
        }

        private static void ExecuteLinkedList()
        {
            Console.WriteLine("=================== Linked List =================== ");
            var linkedNomes = new LinkedList<string>();
            Console.WriteLine("Add Values");
            linkedNomes.Add("Frodo");
            linkedNomes.Add("Sam");
            linkedNomes.Add("Pippin");
            linkedNomes.Add("Merry");
            Console.WriteLine("List size: {0}", linkedNomes.Size);
            Console.WriteLine("List Fisrt: {0}", linkedNomes.First.Value);
            Console.WriteLine("List Last: {0}", linkedNomes.Last.Value);

            WriteLinkedListIterator(linkedNomes);

            for (int i = 0; i < linkedNomes.Size; i++)
                Console.WriteLine("GetNodeAt({0}) {1}", i, linkedNomes.GetNodeAt(i).Value);

            linkedNomes.Remove("Pippin");
            Console.WriteLine("List Remove Pippin");

            linkedNomes.Remove("Merry");
            Console.WriteLine("List Remove Merry");

            for (int i = 0; i < linkedNomes.Size; i++)
                Console.WriteLine("GetNodeAt({0}) {1}", i, linkedNomes.GetNodeAt(i).Value);

            linkedNomes.Add("Gollum");
            Console.WriteLine("List Add Gollum");

            for (int i = 0; i < linkedNomes.Size; i++)
                Console.WriteLine("GetNodeAt({0}) {1}", i, linkedNomes.GetNodeAt(i).Value);



            Console.WriteLine("List size: {0}", linkedNomes.Size);
            Console.WriteLine("List Fisrt: {0}", linkedNomes.First.Value);
            Console.WriteLine("List Last: {0}", linkedNomes.Last.Value);
            Console.WriteLine("=================== End =================== ");
        }

        private static void WriteLinkedListIterator(LinkedList<string> linkedNomes)
        {
            Console.WriteLine("Iterator teste");
            IteratorLikedList<string> iterator = linkedNomes.Iterator();
            while (iterator.HasNext())
            {
                Console.WriteLine("Get node iterator {0}", iterator.Node.Value);
                iterator.GetNext();
            }
            Console.WriteLine("Get node iterator last {0}", iterator.Node.Value);
        }
    }
}
