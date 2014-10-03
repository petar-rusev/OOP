using System;
using Novacode;
using System.Drawing;
using System.Text.RegularExpressions;
namespace WordDocumentGenerator
{
    class CreateDocument
    {
        public DocX document;
        public string path;
        public string name;
        
        public CreateDocument(string FilePath=null, string FileName=null)
        {
            this.Path=FilePath;
            this.Name=FileName;
            this.Document = DocX.Create(this.path + @"\" + this.name);
        }
        public DocX AddHead(string text)
        {
            Formatting head=new Formatting();
            head.Size=25;
            head.Bold = true;
            this.document.InsertParagraph(text,false,head).Alignment = Alignment.center;
            return this.Document;
        }
        public DocX AddImg(string ImagePath)
        {
            Novacode.Image img=this.Document.AddImage(ImagePath);
            Picture pic = img.CreatePicture();
            pic.Height = 250;
            pic.Width = 600;
            this.document.InsertParagraph().Alignment=Alignment.center;
            this.document.InsertParagraph().InsertPicture(pic);
            return this.Document;
        }
        public DocX AddPar(string text=null)
        {
            Formatting par = new Formatting();
            par.Size = 14;
            this.document.InsertParagraph(text, false, par).Alignment = Alignment.left;
            return this.Document;
        }
        public DocX BoldItalic()
        {
            Formatting par=new Formatting();
            par.Bold=true;
            par.Size = 14;
            
            this.Document.ReplaceText("role playing game", "role playing game",false,RegexOptions.None,par,null,MatchFormattingOptions.ExactMatch);
            this.Document.ReplaceText("grand prize!","grand prize!",false,RegexOptions.None,par,null,MatchFormattingOptions.ExactMatch);
            return this.Document;
        }
        
        public List List(string text)
        {
            
            var bull = this.Document.AddList(null, 1, ListItemType.Bulleted, 1);
            this.Document.AddListItem(bull, text, 0, ListItemType.Bulleted, null, false);
            
            return this.Document.InsertList(bull);
        }
        public DocX Document
        {
            get
            {
                return this.document;
            }
            set
            {
                this.document = value;
            }
        }
        public string Path
        {
            get
            {
                return this.path;
            }
            set
            {
                try
                {
                    this.path = value;
                }
                catch (ArgumentNullException)
                {

                }
               
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                try
                {
                    this.name = value;
                }
                catch(ArgumentNullException)
                {
                }
            }
        }
    }
}
