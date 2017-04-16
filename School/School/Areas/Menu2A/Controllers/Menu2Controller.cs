using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using School.DAL;
using School.Areas.Menu2A.ViewModel;
using School.Areas.Menu2A.Models;

namespace School.Areas.Menu2A.Controllers
{
    public class Menu2Controller : Controller
    {
        public ActionResult Index()
        {
            Menu2VM o2VM = new Menu2VM();
            Menu2Model o2M = new Menu2Model();
            if (Request.Form["ClassName"] != null && Request.Form["ClassName"]!= "")
            {
                o2M.ClassName = Request.Form["ClassName"];
                o2M.ClassDescription = Request.Form["ClassDescription"];
                o2M.DateModified = DateTime.Now.ToString();
                if (ModelState.IsValid)
                {
                    DefaultConnection oDAL = new DefaultConnection();
                    oDAL.Menu2Model.Add(o2M);
                    oDAL.SaveChanges();
                    o2VM.menu2Model = new Menu2Model();
                }
                else
                {
                    o2VM.menu2Model = o2M;
                }                
            }
            DefaultConnection oDAL2 = new DefaultConnection();
            List<Menu2Model> oL2M = oDAL2.Menu2Model.ToList<Menu2Model>();
            o2VM.menu2Data = oL2M;
            return View("AddClass", o2VM);
        }

        public ActionResult Modify()
        {
            Menu2VM o2VM = new Menu2VM();
            DefaultConnection dal = new DefaultConnection();
            if (Request.Form["ClassName"] != null && Request.Form["ClassName"] != "")
            {
                int str1 = Convert.ToInt16(Request.Form["Id"]);
                var str2 = Request.Form["ClassName"];
                var str3 = Request.Form["ClassDescription"];
                // Query for a specific record.
                var rowData =
                    (from row in dal.Menu2Model
                     where row.Id == str1
                     select row).First();
                // Change the data of that row.
                rowData.ClassName = str2;
                rowData.ClassDescription = str3;
                rowData.DateModified = DateTime.Now.ToString();
                dal.SaveChanges();
            }
            DefaultConnection oDAL2 = new DefaultConnection();
            List<Menu2Model> oL2M = oDAL2.Menu2Model.ToList<Menu2Model>();
            o2VM.menu2Data = oL2M;
            return View("AddClass", o2VM);
        }

        public ActionResult Delete()
        {
            Menu2VM o2VM = new Menu2VM();
            DefaultConnection dal = new DefaultConnection();
            if (Request.Form["Id"] != null && Request.Form["Id"] != "")
            {
                int str1 = Convert.ToInt16(Request.Form["Id"]);
                // Query for a specific record.
                var rowData =
                    (from row in dal.Menu2Model
                     where row.Id == str1
                     select row).First();
                // Delete the row.
                dal.Menu2Model.Remove(rowData);
                dal.SaveChanges();
            }
            DefaultConnection oDAL2 = new DefaultConnection();
            List<Menu2Model> oL2M = oDAL2.Menu2Model.ToList<Menu2Model>();
            o2VM.menu2Data = oL2M;
            return View("AddClass", o2VM);
        }
    }
}