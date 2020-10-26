using System.Reflection.Metadata.Ecma335;

namespace Estrutura.CSharp.LinkedList
{
    class IteratorLikedList<TEntity>
    {
        public IteratorLikedList(Node<TEntity> node)
        {
            Node = node;
        }

        public bool HasNext() =>
             Node?.Next != null;

        public Node<TEntity> Node { get; private set; }

        public Node<TEntity> GetNext()
        {
            Node = Node.Next;
            return Node.Next;
        }
    }
}
