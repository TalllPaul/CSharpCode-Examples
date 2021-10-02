using System;
using System.Collections.Generic;
using System.Text;

//Child class of Presentation, it will inherit functionality from the parent Presentation class. 

namespace Inheritance
{
    public class Text : Presentation
    {
        public int FontSize { get; set; }
        public string FontName  { get; set; }

        public void AddHyperLink(string url)
        {
            Console.WriteLine("Added a link to " + url);
        }
    }
}
