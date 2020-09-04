using Estrutura.CSharp.LinkedList;
using System;

namespace Estrutura.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================== Linked List =================== ");
            var linkedNomes = new LinkedList<string>();
            linkedNomes.Add("Frodo");
            linkedNomes.Add("Sam");
            linkedNomes.Add("Pippin");
            linkedNomes.Add("Merry");
            Console.WriteLine("Add Value");
            Console.WriteLine("List size: {0}", linkedNomes.Size);
            Console.WriteLine("List Fisrt: {0}", linkedNomes.First.Value);
            Console.WriteLine("List Last: {0}", linkedNomes.Last.Value);
            Console.WriteLine("GetNodeAt(2) {0}", linkedNomes.GetNodeAt(2).Value);
         
            
            
            Console.WriteLine("=================== End =================== ");

        }
    }
}
