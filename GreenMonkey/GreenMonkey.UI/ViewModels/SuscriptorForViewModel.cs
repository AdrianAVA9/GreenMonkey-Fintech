using GreenMonkey.UI.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace GreenMonkey.UI.ViewModels
{
    public class SuscriptorForViewModel
    {
        [Required]
        [MaxLength(4)]
        [MinLength(4)]
        public string Code { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(150)]
        public string Description { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Owner { get; set; }
        
        [Required]
        [MaxLength(50)]
        [Url]
        public string BaseUrl { get; set; }

        public string Heading { get; set; }

        public string Action
        {
            get
            {
                Expression<Func<SuscriptorController, ActionResult>> update =
                    (c => c.Update(this));

                //Expression<Func<SuscriptorController, ActionResult>> create =
                //    (c => c.Create(this));

                var action = !string.IsNullOrEmpty(Code) ? update : null;
                return (action.Body as MethodCallExpression).Method.Name;
            }

        }
    }
}