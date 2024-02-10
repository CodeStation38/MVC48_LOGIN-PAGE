using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcPWy.Models;

namespace MvcPWy.Controllers
{
    public class Customers2Controller : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Customers2
        public ActionResult Index(string prefColor, string mainHobbyString)
        {
            //PREFCOLOR DROPDOWNLIST
            var PrefColorLst = new List<string>();

            var PrefColorQry = from d in db.Customers
                           orderby d.PrefferedColor
                               select d.PrefferedColor;

            PrefColorLst.AddRange(PrefColorQry.Distinct());
            ViewBag.prefColor = new SelectList(PrefColorLst);

            //MAINHOBBY DROPDOWNLIST
            var MainHobbyLst = new List<string>();

            var MainHobbyQry = from d in db.Customers
                               orderby d.MainHobby
                               select d.MainHobby;

            MainHobbyLst.AddRange(MainHobbyQry.Distinct());
            ViewBag.mainHobbyString = new SelectList(MainHobbyLst);


            //CUSTOMERS DATASET
            var customersls = from m in db.Customers
                         select m;

            //if (!String.IsNullOrEmpty(searchString))
            //{
            //    customersls = customersls.Where(s => s.MainHobby.Contains(searchString));
            //}
            if (!string.IsNullOrEmpty(mainHobbyString))
            {
                customersls = customersls.Where(x => x.MainHobby == mainHobbyString);
            }

            if (!string.IsNullOrEmpty(prefColor))
            {
                customersls = customersls.Where(x => x.PrefferedColor == prefColor);
            }
            return View(customersls);
        }

        // GET: Customers2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // GET: Customers2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FirstName,LastName,Birthday,PrefferedColor,MainHobby,SSN,NumberOfRooms")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        // GET: Customers2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FirstName,LastName,Birthday,PrefferedColor,MainHobby,SSN,NumberOfRooms")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        // GET: Customers2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer customer = db.Customers.Find(id);
            db.Customers.Remove(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
