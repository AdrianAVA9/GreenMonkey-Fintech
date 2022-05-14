using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreenMonkey.UI.Models.Controls
{
    public class CtrlTableModel : CtrlBaseControl
    {
        public string Title { get; set; }
        public string Columns { get; set; }
        public string ColumnsDataName { get; set; }
        public string FunctionName { get; set; }
        public int ColumnsCount => Columns.Split(',').Length;
        public CtrlTableModel()
        {
            Columns = "";
        }
        public string ColumnHeaders
        {
            get
            {
                var headers = "";
                foreach (var text in Columns.Split(','))
                {
                    headers += "<th>" + text + "</th>";
                }

                return headers;
            }
        }

        public override string GetHtml()
        {
            var html = ReadFileText();

            foreach(var prop in this.GetType().GetProperties())
            {
                if(prop != null)
                {
                    var value = prop.GetValue(this, null).ToString();
                    var tag = string.Format("-#{0}-", prop.Name);
                    html = html.Replace(tag, value); 
                }
            }

            return html;
        }
    }
}