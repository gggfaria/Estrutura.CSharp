using System;

namespace Estrutura.CSharp.LinkedList
{
    class LinkedList<TEntity>
    {
        public Node<TEntity> First { get; set; }
        public Node<TEntity> Last { get; set; }
        public int Size { get; set; }

        public void Add(TEntity value)
        {
            var node = new Node<TEntity>(value);
            if (First == null && Last == null)
                Last = First = node;
            else
                Last = Last.Next = node;
            Size++;
        }

        public Node<TEntity> GetNodeAt(int index)
        {
            Node<TEntity> currentNode = First;
            for (int i = 0; i < index; i++)
                currentNode = currentNode.Next;
            return currentNode;
        }
    }
}
