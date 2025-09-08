namespace Student_Manager_Console_App;

internal class GenericClass<T>
{
    public GenericClass(T value)
    {
        Value = value;
    }

    public T Value { get; set; }
}
