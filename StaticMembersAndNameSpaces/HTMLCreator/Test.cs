using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLDispatcher.HTMLCreator
{
    class Test
    {
        static void Main()
        {
            //Created with the method CreatedImage in class HTMLDispatcher
            string testOne = HTMLDispatcher.CreateImage("picture.jpg", "Softuni Dudes", "picture One");
            Console.WriteLine(testOne);

            //Created with the Elementbuilder class directly
            ElementBuilder testTwo = new ElementBuilder("div");
            testTwo.AddAttribute("class", "big");
            Console.WriteLine(testTwo);
            

            //Created with the method CreatedImage in class HTMLDispatcher
            string testThree = HTMLDispatcher.CreateURL("href", "http://www.w3schools.com/html/", "Visit our HTML tutorial");
            Console.WriteLine(testThree);

            //Created with the method CreatedImage in class HTMLDispatcher
            string testFour = HTMLDispatcher.CreateInput("text","fname", "Submit");
            Console.WriteLine(testFour);
        }
    }
}
