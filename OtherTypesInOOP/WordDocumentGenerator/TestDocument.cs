using System;
using Novacode;
using System.Drawing;

namespace WordDocumentGenerator
{
    public class TestDocument
    {
        static void Main()
        {
            string partOne="SoftUni OOP Game Contest";
            string partTwo = "SoftUni is organizing a contest for the best role playing game from the OOP teamwork";
            string partThr = "projects. The winning teams will receive a grand prize!";
            string partFour = "The game should be: ";
            string listOne="Properly structured and follow all good OOP practices";
            string listTwo="Awesome..";
            string lsitThr="Very Awesome";
            string []bul={listOne,listTwo,lsitThr};
            string paragraphs = partOne + partTwo + partThr;
            Console.WriteLine("Please enter the directory where you want to create the file.");
            string path = Console.ReadLine();
            Console.WriteLine("Please enter the name of the file which will be created.");
            string name = Console.ReadLine()+".docx";
            CreateDocument TestDoc=new CreateDocument(path,name);
            Console.WriteLine("Please enter the image directory and name.");
            string ImgPath = Console.ReadLine();
            TestDoc.AddHead(partOne);
            TestDoc.AddImg(ImgPath);
            TestDoc.AddPar();
            TestDoc.AddPar(paragraphs);
            TestDoc.AddPar(partFour);
            TestDoc.AddPar();
            TestDoc.BoldItalic();
            for (int i = 0; i < 3; i++)
            {
                TestDoc.List(bul[i]);
            }
            TestDoc.AddHead("The top 3 teams will recieve a SPECTACULAR prize:");
            TestDoc.AddHead("A HANDSHAKE FROM NAKOV");
            TestDoc.document.Save();
        }
    }
}
