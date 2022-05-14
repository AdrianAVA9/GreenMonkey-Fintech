using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace GreenMonkey.UI.Models.Controls
{
    public abstract class CtrlBaseControl
    {
        public string Id { get; set; }
        public string ViewName { get; set; }
        public abstract string GetHtml();

        public string ReadFileText()
        {
            string filename = this.GetType().Name + ".html";
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\" + Path.Combine(@"Models/Controls/Template/", filename);
            string text = File.ReadAllText(path);
            return text;
        }
    }
}