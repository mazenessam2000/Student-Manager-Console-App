using Student_Manager_Console_App;
using System.Diagnostics;
using System.Xml.Linq;

List<Student> students = new List<Student>()
{
    new Student("Mazen", 50),
    new Student("Ahmed", 100),
    new Student("Andrew", 30),
    new Student("Hassan", 100),
    new Student("Mohammed", 20)
};

students.Add(new Student("Mina", 60));
students.RemoveAll(n => n.Name == "Hassan");
var orderedStudents = students.OrderBy(s => s.Grade).Select(s => $"Student: <{s.Name}>, Grade: <{s.Grade}>").ToList();

foreach (var student in orderedStudents)
{
    Console.WriteLine(student);
}
Console.WriteLine();

var topStudent = students.OrderByDescending(s => s.Grade).First();
var topStudentGeneric = new GenericClass<Student>(topStudent);

Console.WriteLine($"Top student stored in GenericClass: {topStudentGeneric.Value.Name} - {topStudentGeneric.Value.Grade}");