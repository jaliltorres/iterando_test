using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web_iterando.Models;
using web_iterando.Servicios;

namespace web_iterando.Controllers
{
    public class PersonController : Controller
    {

        private PersonService serv;

        public PersonController()
        {
            serv = new PersonService();
        }


        // GET: Person
        public ActionResult Index()
        {
            return View(serv.ListPeople());
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(Person person)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    serv.Crear(person);
                    return RedirectToAction("Index");
                }

            }
            catch (Exception ex)
            {
                //return error
                if (ex.Source != null)
                {
                    Console.WriteLine("Error code: ", ex.Source);
                }
            }

            return View();
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Person/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
