namespace CustomLinqExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class TestCustomLinqExtensions
    {
        public static void Main()
        {
            Queue<int> test=new Queue<int>();
            for (int i = 0; i < 50; i++)
            {
                test.Enqueue(i);
            }
            var result = test.WhereNot(x => (x % 2) == 0);
            Console.Write("Test WhereNot: ");
            foreach(var item in result)
            {
                Console.Write(item);
                
            }
            Console.WriteLine();
            var resultOne = test.Repeat(2);
            Console.Write("Test Repeat: ");
            foreach (var item in resultOne)
            {
                Console.Write(item);
                
            }
            Console.WriteLine();
            Queue<string> names = new Queue<string>();
            names.Enqueue("Petar");
            names.Enqueue("Rusev");
            names.Enqueue("Rusev");
            Console.Write("Test WhereEndsWith: ");
            List<string> suffixes=new List<string>();
            suffixes.Add("v");
            var resultTwo=names.WhereEndsWith(suffixes);
            foreach (var item in resultTwo)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine();
        }
    }
}
