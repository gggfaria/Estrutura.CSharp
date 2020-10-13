namespace Estrutura.CSharp.LinkedList
{
    class IteratorLikedList<TEntity>
    {
        private Node<TEntity> _node;
        public IteratorLikedList(Node<TEntity> node)
        {
            _node = node;
        }

        public bool HasNext() =>
             _node?.Next != null;

        public Node<TEntity> GetNext()
        {
            _node = _node.Next;
            return _node.Next;
        }
    }
}
