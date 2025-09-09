namespace StudentManagerApp;

internal class StudentManager
{
    private readonly List<Student> _students;
    private readonly Student _topStudent;
    private readonly GenericContainer<Student> _topStudentContainer;
    private readonly List<Student> _orderedStudents;
    private readonly List<Student> _distinctStudents;

    public StudentManager()
    {
        _students = new List<Student>
        {
            new Student("Mazen", 50),
            new Student("Ahmed", 100),
            new Student("Andrew", 30),
            new Student("Hassan", 100),
            new Student("Mohammed", 20),
            new Student("Mina", 60),
            new Student("Mazen", 100) // duplicate name to test distinct
        };

        _orderedStudents = _students.OrderBy(s => s.Grade).ToList();
        _topStudent = _students.OrderByDescending(s => s.Grade).First();
        _topStudentContainer = new GenericContainer<Student>(_topStudent);
        _distinctStudents = _students.DistinctBy(s => s.Name).ToList();
    }

    public void PrintStudents()
    {
        foreach (var student in _students)
        {
            Console.WriteLine(student);
        }
    }

    public void PrintOrderedStudents()
    {
        foreach (var student in _orderedStudents)
        {
            Console.WriteLine(student);
        }
    }

    public void PrintDistinctStudents()
    {
        foreach (var student in _distinctStudents)
        {
            Console.WriteLine(student);
        }
    }

    public void PrintTopStudent()
    {
        Console.WriteLine($"Top student stored in GenericContainer: {_topStudentContainer.Value}");
    }

    public bool HasPerfectScore()
    {
        return _students.Any(s => s.Grade == 100);
    }

    public bool AllAbove50()
    {
        return _students.All(s => s.Grade >= 50);
    }

    public int GetTotalGrades()
    {
        return _students.Sum(s => s.Grade);
    }

    public double GetAverageGrade()
    {
        return _students.Average(s => s.Grade);
    }

    public void PrintGroupedByGrade()
    {
        var grouped = _students.GroupBy(s => s.Grade);

        foreach (var group in grouped)
        {
            Console.WriteLine($"Grade: {group.Key}");

            foreach (var student in group)
            {
                Console.WriteLine($"   - {student.Name}");
            }

            Console.WriteLine();
        }
    }
}