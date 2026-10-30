using JetBrains.Annotations;

namespace Ex_8
{
    public class GenericNode<T>
    {
        public T Value;
        [CanBeNull] public GenericNode<T> Next;
    }
}