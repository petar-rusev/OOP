using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HTMLDispatcher.HTMLCreator
{
    class ElementBuilder
    {
        private string element;
        private string open;
        private string close;
        private string content;

        public string Open
        {
            get
            {
                return this.open;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid open tag.The open tag can not be empty or null string!");
                }
                else
                {
                    this.open = value;
                }
            }
        }
        public string Close
        {
            get
            {
                return this.close;
            }
            set
            {
                this.close = value;
            }
        }
        public string Element
        {
            get
            {
                return this.element;
            }
            set
            {
                string pat=@"[A-Za-z]+";
                Regex reg=new Regex(pat);
                Match match=reg.Match(value);
                if (string.IsNullOrEmpty(value)||match.Success==false)
                {
                    throw new ArgumentException("Invalid element argument exception!The element can not be empty or null string.");
                }
                else
                {
                    this.element = value;
                }
            }
        }
        public string Content
        {
            get
            {
                return this.content;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The whole html element can not be empty or null string!");
                }
                else
                {
                    this.content = value;
                }
            }
        }
       
        public ElementBuilder(string htmlElement)
        {
            this.Element = htmlElement;
            this.Open = "<" + this.Element + ">";
            this.Close = "<" + this.Element + "/" + ">";
            
        }

        public void AddAttribute(string attribute=null, string value=null)
        {
            string tempOpen = this.Open;
            string partOne = "";
            string parttwo = "";
            string att = attribute+"="+"\"" + value+"\"";
            for (int i = 0; i < tempOpen.IndexOf('>'); i++)
            {
                partOne+=tempOpen[i];
            }
            parttwo = ">";
            string tempTwo=" "+att+parttwo;
            this.Open = partOne + tempTwo;
            
        }

        public void AddContent(string content=null)
        {
            this.Content = content;
        }

        public static string operator *(ElementBuilder html,int mult)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < mult; i++)
            {
                sb.Append(html.ToString());
            }
            
            return sb.ToString();

        }	

        public override string ToString()
        {
            if (this.Close == null)
            {
                return string.Format(this.Open + this.Content);
            }
            else
            {
                return string.Format(this.Open+this.Content+this.Close);
            }
            
        }

    }
}
//return string.Format("name: {0}, age: {1}", this.Name, this.Age) + (this.email == null ? "" : ", email: " + this.email);