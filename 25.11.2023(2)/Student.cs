

using System.Drawing;

namespace _25._11._2023_2_
{
    public class Student
    {
        public int Id { get; } = 1;
        public string FullName { get; set; }
        public int Point { get; set; }

    }
    public void StudentInfo()
    {
        Console.WriteLine($"Student ID: {Id}");
        Console.WriteLine($"Full Name: {FullName}");
        Console.WriteLine($"Points: {Point}");
        
    }
}
