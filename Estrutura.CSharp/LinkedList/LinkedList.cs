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

        public bool Remove(TEntity value)
        {
            Node<TEntity> currentNode = First;
            Node<TEntity> previousNode = null;
            for (int i = 0; i < Size; i++)
            {
                if (currentNode.Value.Equals(value))
                {
                    Size--;
                    if (previousNode == null)
                        First = currentNode.Next;
                    else if (currentNode.Next == null)
                        Last = previousNode;
                    else
                        previousNode.Next = currentNode.Next;
                    return true;

                }
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }

            return false;
        }

        public IteratorLikedList<TEntity> Iterator()
        {
            return new IteratorLikedList<TEntity>(First);
        }

    }
}
