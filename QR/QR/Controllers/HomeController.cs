using QR.Models;
using QR.Repositories;
using QR.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QR.Controllers
{
    public class HomeController : Controller
    {
        private IRepository rep = null;

        public HomeController(IRepository rep) { this.rep = rep; }

        public ActionResult Index()
        {
            return View(rep.GetAll());
        }

        public ActionResult Details(int Id)
        {
            QuestRoom room = rep.GetById(Id);
            if (room != null) return View(room);
            else return new HttpNotFoundResult("Quest room doesn't exist");
        }
        public ActionResult AddingRoom(QuestRoom newRoom)
        {
            rep.Add(newRoom);
            return View("Index"); 
        }
    }
}