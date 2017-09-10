using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ShowroomController : Controller
    {
        List<car> car = new List<car>();


        public ShowroomController()
        {

            car.Add(new car() { id = 1, Model = "2006", Name = "Cultus", price = "12000000" });
            car.Add(new car() { id = 2, Model = "2015", Name = "Cultus", price = "15000000" });
            car.Add(new car() { id = 3, Model = "2017", Name = "Cultus", price = "22000000" });
            
        
        }
        //
        // GET: /Showroom/
        public ActionResult Index()
        {
           
            return View(car);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(car car1)
        {
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var editing = car.Find(d => d.id == id);
            return View(editing);
        }
        public ActionResult Details(int id)
        {
            var editing = car.Find(d => d.id == id);
            return View(editing);
        }
        public ActionResult Delete(int id)
        {
            var editing = car.Find(d => d.id == id);
            return View(editing);
         
        }
    }


}