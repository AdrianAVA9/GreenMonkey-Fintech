using GreenMonkey.UI.Models.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GreenMonkey.UI.Models.Helpers
{
    public static class ControlExtensions
    {
        public static HtmlString CtrlButton(this HtmlHelper html, string viewname, string id, string label, string onClickFunction = "", 
            string buttonType = "button", string btnClass = "btn btn-primary")
        {
            var ctrl = new CtrlButtonModel() { 
                Id = id,
                Label = label,
                Event = onClickFunction,
                Class = btnClass,
                ViewName = viewname,
                FunctionName = onClickFunction,
                Type = buttonType
            }; 
            
            return new HtmlString(ctrl.GetHtml());
        }

        public static HtmlString CtrlTextbox(this HtmlHelper html, string viewname, string id, string label, string onClickFunction="", string name="",
            string classname="form-control", string type = "text", string placeholder="", string value="")
        {
            var ctrl = new CtrlTextbox()
            {
                Id = id,
                Label = label,
                Name = name,
                Class = classname,
                Type = type,
                Value = value,
                Placeholder = placeholder
            };

            return new HtmlString(ctrl.GetHtml());
        }
        public static HtmlString CtrlTable(this HtmlHelper html, string viewName, string id, string title,
            string columnsTitle, string ColumnsDataName, string onSelectFunction, string colorHeader)
        {
            var ctrl = new CtrlTableModel
            {
                ViewName = viewName,
                Id = id,
                Title = title,
                Columns = columnsTitle,
                ColumnsDataName = ColumnsDataName,
                FunctionName = onSelectFunction
            };

            return new HtmlString(ctrl.GetHtml());
        }
    }
}