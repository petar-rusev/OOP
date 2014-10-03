namespace StringBuilderExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class TestExtensions
    {
        public static void Main()
        {
            StringBuilder test = new StringBuilder("Petar e golqm pich petar Petar! :)");
            string SubStringTest=test.Substring(4, test.Length);
            Console.WriteLine(SubStringTest);
            test.RemoveText("Petar");
            Console.WriteLine(test);

            List<int> TestListOne = new List<int>();
            List<string> TestListTwo = new List<string>();

            TestListOne.Add(1);
            TestListOne.Add(2);
            TestListTwo.Add("Petar");
            TestListTwo.Add("Rusev");
            TestListTwo.Add("Rusev");
            test.Clear();
            test.AppendAll(TestListOne);
            test.AppendAll(TestListTwo);
            Console.WriteLine(test);

        }
    }
}
