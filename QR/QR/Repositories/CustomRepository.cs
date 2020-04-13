using QR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QR.Repositories
{
    public class CustomRepository : IRepository
    {
        QRContext db;

        public CustomRepository(QRContext context)
        {
            this.db = context;
        }

        public int Count { get; set; }

        public List<QuestRoom> GetAll() {
            var list = db.Rooms.ToList();
            return list;
        }

        public QuestRoom GetById(int id) {
            return db.Rooms.FirstOrDefault(i => i.ID == id);
        }

        public void DeleteById(int id)
        {
            var room = db.Rooms.Find(id);
            db.Rooms.Remove(room);
            db.SaveChanges();
        }

        public void PushById(QuestRoom obj, int id)
        {
            var room = db.Rooms.Find(id);
            room.Name = obj.Name;
            db.SaveChanges();
        }

        public void Add(QuestRoom item)
        {
            db.Rooms.Add(item);
            db.SaveChanges();
        }
    }
}