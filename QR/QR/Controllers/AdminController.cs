using QR.Models;
using QR.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QR.Controllers
{
    public class AdminController : Controller
    {
        private IRepository rep = null;
        // GET: Admin
        public  AdminController(IRepository rep) {
            this.rep = rep;
        }

        public ActionResult Index()
        {
            return View(rep.GetAll());
        }
        
        [HttpGet]
        public ActionResult AddingRoom()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddQuest(QuestRoom newRoom)
        {
            rep.Add(newRoom);
            return RedirectToAction("AddingRoom", "Admin");
        }

        [HttpPost]
        public ActionResult EditingRoom(int Id)
        {
            return View(rep.GetById(Id));
        }
        [HttpPost]
        public ActionResult EditQuest(QuestRoom newRoom)
        {
            rep.PushById(newRoom, newRoom.ID);
            return View("Index", rep.GetAll());
        }

        [HttpPost]
        public ActionResult DeleteQuest(int Id)
        {
            rep.DeleteById(Id);
            return View("Index", rep.GetAll());
        }
        
    }
}