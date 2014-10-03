using System;

namespace HTMLDispatcher.HTMLCreator
{
    static class HTMLDispatcher
    {
        public static string CreateImage(string source, string alt, string title)
        {
           
            ElementBuilder img = new ElementBuilder("img");
            img.AddAttribute("source",source);
            img.AddAttribute("alt",alt);
            img.AddAttribute("title",title);
            img.Close = null;
            return img.ToString();
        }
        public static string CreateURL(string url, string title, string text)
        {
            ElementBuilder URL = new ElementBuilder("a");
            URL.AddAttribute(url,title);
            URL.AddContent(text);
            return URL.ToString();
        }
        public static string CreateInput(string type, string name, string value)
        {
            ElementBuilder input = new ElementBuilder("input");
            input.AddAttribute("type",type);
            input.AddAttribute("name",name);
            input.AddAttribute("value", value);
            input.Close = null;
            return input.ToString();
        }
    }
}
