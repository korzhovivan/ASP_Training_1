using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QR.Models
{
    public class QuestRoom 
    {
        public QuestRoom() { }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Adress { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public int FearLvl { get; set; }
        public int HardLvl { get; set; }

       public int DurationTime { get; set; }
    }
}