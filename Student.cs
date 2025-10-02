using System;

public class Student
{
    public void studentRun()
    {
        StudentList studentList = new StudentList();
        studentList.AddStudent("Claire", 1001, 90);
        studentList.AddStudent("Bob", 1002, 85);
        studentList.DisplayStudents();
    }
}

public class studentData
{
    public string Name;
    public int StudentID;
    public int Grades;
}

public class StudentList
{
    public List<studentData> students = new List<studentData>();

    public void AddStudent(string name, int studentID, int grades)
    {
        studentData newStudent = new studentData();
        newStudent.Name = name;
        newStudent.StudentID = studentID;
        newStudent.Grades = grades;
        students.Add(newStudent);
    }

    public void DisplayStudents()
    {
        var maxGrade = students.Max(s => s.Grades);
        var studentsWithMaxGrade = students.Where(s => s.Grades == maxGrade);
        foreach (var s in studentsWithMaxGrade)
        {
            Console.WriteLine($"Name: {s.Name}, Highest Grade: {maxGrade}");
        }
        var avgGrade = students.Average(s => s.Grades);
        Console.WriteLine($"Average Grade: {avgGrade}");


        // foreach (var student in students)
        // {
        //     Console.WriteLine($"Name: {student.Name}, Student ID: {student.StudentID}, Grades: {student.Grades}");
        // }
    }
}