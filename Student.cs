namespace Student_Manager_Console_App;

internal class Student
{
    public string Name { get; set; }
    private int grade;

    public int Grade
    {
        get => grade;
        set
        {
            if (value >= 0 && value <= 100)
                grade = value;
            else
                throw new ArgumentOutOfRangeException("Grade must be between 0 - 100");
        }
    }

    public Student(string name, int grade)
    {
        Name = name;
        Grade = grade;
    }
}
