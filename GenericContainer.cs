namespace StudentManagerApp;

internal class GenericContainer<T>
{
    public T Value { get; }

    public GenericContainer(T value)
    {
        Value = value;
    }
}