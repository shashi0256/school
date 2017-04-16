using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using School.Models;
using School.ViewModel;
using School.DAL;

namespace School.Controllers
{
    public class MainMenuController : Controller
    {
        // GET: MainMenu
        public ActionResult Index()
        {
            MenuViewModel MVM = new MenuViewModel();
            MVM.menuModal = new MenuModal();
            DefaultConnection obj = new DefaultConnection();
            List<MenuModal> menuscoll = obj.Menus.ToList<MenuModal>();
            MVM.menus = menuscoll;
            return View("Menu", MVM);
        }
    }
}