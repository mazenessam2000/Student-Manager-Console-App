using StudentManagerApp;

var manager = new StudentManager();

while (true)
{
    Console.WriteLine("""
    ========== Student Manager ==========
    1 - Show all students
    2 - Show ordered students (by grade)
    3 - Show distinct students (by name)
    4 - Show top student
    5 - Check if any student has 100
    6 - Check if all students >= 50
    7 - Show sum of grades
    8 - Show average grade
    9 - Group students by grade
    0 - Exit
    =====================================
    """);

    Console.Write("Enter your choice: ");
    var choice = Console.ReadLine();
    Console.WriteLine();

    switch (choice)
    {
        case "1":
            manager.PrintStudents();
            break;
        case "2":
            manager.PrintOrderedStudents();
            break;
        case "3":
            manager.PrintDistinctStudents();
            break;
        case "4":
            manager.PrintTopStudent();
            break;
        case "5":
            Console.WriteLine(manager.HasPerfectScore()
                ? "There is at least one student with grade 100."
                : "No student has grade 100.");
            break;
        case "6":
            Console.WriteLine(manager.AllAbove50()
                ? "All students have grades >= 50."
                : "Not all students have grades >= 50.");
            break;
        case "7":
            Console.WriteLine($"Total grades: {manager.GetTotalGrades()}");
            break;
        case "8":
            Console.WriteLine($"Average grade: {manager.GetAverageGrade():F2}");
            break;
        case "9":
            manager.PrintGroupedByGrade();
            break;
        case "0":
            Console.WriteLine("Exiting program...");
            return;
        default:
            Console.WriteLine("Invalid choice, please try again.");
            break;
    }

    Console.WriteLine(new string('-', 50));
}