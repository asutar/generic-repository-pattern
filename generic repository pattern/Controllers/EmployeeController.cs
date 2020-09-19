using generic_repository_pattern.Models;
using generic_repository_pattern.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace generic_repository_pattern.Controllers
{
    public class EmployeeController : Controller,IDisposable
    {
        private _IAllRepository<EmployeeMaster> interfaceobj;
        public EmployeeController()
        {
            this.interfaceobj = new AllRepository<EmployeeMaster>();
        }
        // GET: Employee
        public ActionResult Index()
        {
            return View(from m in interfaceobj.GetModel() select m);
        }

        // GET: MyBooks/Details/5
        public ActionResult Details(int id)
        {
            EmployeeMaster b = interfaceobj.GetModelByID(id);
            return View(b);
        }

        // GET: MyBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MyBooks/Create
        [HttpPost]
        public ActionResult Create(EmployeeMaster collection)
        {
            try
            {
                // TODO: Add insert logic here
                interfaceobj.InsertModel(collection);
                interfaceobj.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MyBooks/Edit/5
        public ActionResult Edit(int id)
        {
            EmployeeMaster b = interfaceobj.GetModelByID(id);
            return View(b);
        }

        // POST: MyBooks/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, EmployeeMaster collection)
        {
            try
            {
                // TODO: Add update logic here
                interfaceobj.UpdateModel(collection);
                interfaceobj.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MyBooks/Delete/5
        public ActionResult Delete(int id)
        {

            EmployeeMaster b = interfaceobj.GetModelByID(id);
            return View(b);
        }

        // POST: MyBooks/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, EmployeeMaster collection)
        {
            try
            {
                // TODO: Add delete logic here
                interfaceobj.DeleteModel(id);
                interfaceobj.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
    }
}
