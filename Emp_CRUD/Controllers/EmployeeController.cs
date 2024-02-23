using Emp_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Emp_CRUD.Controllers
{
    public class EmployeeController : Controller
    {
        Datacontext db=new Datacontext();
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> employees =new List<Employee>();
            employees =db.employees.ToList();
            return View(employees);
        }
        [HttpGet]
        public ActionResult Create()
        {
            Employee employee = new Employee();
            employee=db.employees.Add(employee);
            return View(employee);
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if(ModelState.IsValid)
            {
                db.employees.Add(employee);
                db.SaveChanges();
                Response.Redirect("Index");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            Employee emp=new Employee();
            emp = db.employees.Find(Id);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            db.Entry(emp).State=System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int Id)
        {
            Employee emp = new Employee();
            emp=db.employees.Find(Id);
            return View(emp);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult postDelete(int Id)
        {
            Employee emp = db.employees.Find(Id);
            db.employees.Remove(emp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Details(int Id)
        {
            Employee emp = db.employees.Find(Id);
            return View(emp);
        }
    }
}