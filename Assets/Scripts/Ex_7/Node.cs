using JetBrains.Annotations;

namespace Ex_7
{
    public class Node
    {
        public int Value;
        [CanBeNull] public Node Next;
    }
}