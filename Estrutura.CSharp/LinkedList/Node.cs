namespace Estrutura.CSharp.LinkedList
{
    class Node<TEntity>
    {
        public Node(TEntity entity)
        {
            Value = entity;
        }
        public Node<TEntity> Next { get; set; }
        public TEntity Value { get; set; }

    }
}
