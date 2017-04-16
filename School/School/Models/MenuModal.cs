using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace School.Models
{
    public class MenuModal
    {
        [Key]
        public int Id { get; set; }
        public string MenuItem { get; set; }
        public string MenuIcon { get; set; }
        public string MenuItemHref { get; set; }
    }
}   