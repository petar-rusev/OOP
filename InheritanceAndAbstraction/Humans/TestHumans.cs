using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    class TestHumans
    {
        static void Main(string[] args)
        {
            Student one = new Student("Petar", "Rusev", "897654");
            Student two = new Student("Mariq", "Rusev", "897987");
            Student three = new Student("Ivan", "Ivanov", "468573");
            Student four = new Student("Kolio", "Kolev", "124312");
            Student five = new Student("Petya", "Ivanov", "12345678");
            Student six = new Student("Maq", "Popova", "4645131");
            Student seven = new Student("Jeko", "Kolev", "789312");
            Student eight = new Student("Petko", "Ivanov", "4546231");
            Student nine = new Student("Lora", "Karadjova", "123465");
            Student ten = new Student("Kubrat", "Pulev", "11111111");

            Worker wOne = new Worker("Kolio", "Rusev",3000,8);
            Worker wTwo = new Worker("Marcho", "Grozev",1200,5);
            Worker wThree = new Worker("Ivo", "Ivanov",600,10);
            Worker wFour = new Worker("Katya", "Koleva",850,8);
            Worker wFive = new Worker("Petran", "Ivanov",200,3);
            Worker wSix = new Worker("Maq", "Popova",10,1);
            Worker wSeven = new Worker("Jeko", "Kolev",150,3);
            Worker wEight = new Worker("Slavi", "Ivanov",100000,5);
            Worker wNine = new Worker("Lora", "Petkova",1234,8);
            Worker wTen = new Worker("Kubrat", "Pulev",2546,10);

            List<Worker> workers = new List<Worker>();
            List<Student> students = new List<Student>();
            workers.Add(wOne);
            workers.Add(wTwo);
            workers.Add(wThree);
            workers.Add(wFour);
            workers.Add(wFive);
            workers.Add(wSix);
            workers.Add(wSeven);
            workers.Add(wEight);
            workers.Add(wNine);
            workers.Add(wTen);

            students.Add(one);
            students.Add(two);
            students.Add(three);
            students.Add(four);
            students.Add(five);
            students.Add(six);
            students.Add(seven);
            students.Add(eight);
            students.Add(nine);
            students.Add(ten);

            SortStudents(students);
            SortWorkers(workers);
                     
            List<Human> FinalSort =SortMergeList(workers,students);
            foreach (Human h in FinalSort)
            {
                Console.WriteLine(h);
            }
        }

        public static void SortStudents(List<Student> students)
        {
            students.OrderByDescending(num => num.FacultyNumber).Reverse();

        }

        public static void SortWorkers(List<Worker> workers)
        {
            workers.OrderByDescending(worker => worker.MoneyPerHour(worker));
        }

        public static List<Human> SortMergeList(List<Worker> workers,List<Student> students)
        {
            List<Human> result = new List<Human>();
            result.AddRange(workers);
            result.AddRange(students);
            result.OrderBy(human => human.FirstName)
                .ThenBy(human => human.LastName);
            return result;
        }
    }
}
