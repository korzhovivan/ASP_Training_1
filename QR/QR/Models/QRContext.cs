using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace QR.Models
{
    public class QRContext:DbContext
    {
        static QRContext()
        {
            Database.SetInitializer<QRContext>(new QRContextInitializer());
        }

        public QRContext() : base("QRContext") {
            
        }

        public DbSet<QuestRoom> Rooms { set; get; }
    }
    public class QRContextInitializer:DropCreateDatabaseAlways<QRContext>
    {
        protected override void Seed(QRContext context)
        {
            context.Rooms.Add(new QuestRoom()
            { ID = 0, Name = "Apocalipsis", Phone2 = "0972524254", Description = "the word destroyed", Adress = "Getmaskaya 74", Phone1 = "0977112905", FearLvl = 4, HardLvl = 6, DurationTime = 36 });
            context.Rooms.Add(new QuestRoom
            { ID = 1, Name = "DieZone", Phone2 = "0972524254", Description = "Hard lvl of skill", Adress = "Yakira 3", Phone1 = "0977112905", FearLvl = 2, HardLvl = 10, DurationTime = 20 });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}