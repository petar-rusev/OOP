using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class TestSchool
    {
        static void Main(string[] args)
        {
            Student first=new Student("Mariq","564710");
            Student second = new Student("Pesho", "111123", "Gouem pich");
            Student third = new Student("Ganka", "126578");
            Disciplines basic = new Disciplines(10, "C# programming", "This is the prepration level at SoftUni.");
            Disciplines intermediate = new Disciplines(20, "Object Oriented Programming");
            Disciplines advanced = new Disciplines(30, "Structures of data and Algorithms", "This is the third level in SoftUni.");
            List<Student> students = new List<Student>();
            students.Add(first);
            students.Add(second);
            students.Add(third);

            List<Disciplines>SetOne=new List<Disciplines>();
            SetOne.Add(intermediate);
            SetOne.Add(intermediate);
            SetOne.Add(advanced);
            Teacher Nakov = new Teacher("Nakov", SetOne, "Gouem pich too :)");
            Teacher Znaiko = new Teacher("Znaiko", SetOne);
            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(Nakov);
            teachers.Add(Znaiko);
            Class begginers = new Class(teachers,students);
            
        }
    }
}
