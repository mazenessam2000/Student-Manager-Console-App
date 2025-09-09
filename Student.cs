namespace StudentManagerApp;

internal class Student
{
    public string Name { get; set; }
    private int _grade;

    public int Grade
    {
        get => _grade;
        set
        {
            if (value is < 0 or > 100)
                throw new ArgumentOutOfRangeException(nameof(Grade), "Grade must be between 0 - 100");
            _grade = value;
        }
    }

    public Student(string name, int grade)
    {
        Name = name;
        Grade = grade;
    }

    public override string ToString()
    {
        return $"Student: {Name}, Grade: {Grade}";
    }
}