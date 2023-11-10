using Encapsulation.Models;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Elxan", "Mammadli", 90);
            Student student2 = new Student("Elcan", "Mammadli", 70);
            Student student3 = new Student("Zerife", "Mammadli", 100);
            Student student4 = new Student("Ilham", "Mikayilov", 80);
            Student student5 = new Student("Murad", "Babayev", 60);
            Student student6 = new Student("Ali", "Farzaliyev", 75);

            Group group1 = new Group("AB101",15);
            Group group2 = new Group("AP104",10);
            group1.AddStudent(student1);
            group1.AddStudent(student2);
            group1.AddStudent(student3);

            group2.AddStudent(student4);
            group2.AddStudent(student5);
            group2.AddStudent(student6);


            group2.FilterByName("m M");
        }
    }
}