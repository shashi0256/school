using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using School.Areas.Menu2A.Models;

namespace School.Areas.Menu2A.ViewModel
{
    public class Menu2VM
    {
        public Menu2Model menu2Model { get; set; }
        public List<Menu2Model> menu2Data { get; set; }
    }
}