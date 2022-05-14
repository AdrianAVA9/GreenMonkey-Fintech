using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreenMonkey.UI.Models.Controls
{
    public class CtrlTextbox
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
        public string Placeholder { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }

        public string GetHtml()
        {
            return "<div class=\"form-group\">" +
                $"<label class=\"col-form-label\" for=\"{Id}\">{Label}</label>" +
              $"<input type=\"{Type}\" class=\"{Class}\" placeholder=\"{Placeholder}\" id=\"{Id}\" name=\"{Name}\" ColumnDataName=\"{Name}\">" +
            "</div>";
        }
    }
}