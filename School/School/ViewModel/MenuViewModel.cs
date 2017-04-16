using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using School.Models;

namespace School.ViewModel
{
    public class MenuViewModel
    {
        public MenuModal menuModal { get; set; }
        public List<MenuModal> menus { get; set; }
    }
}