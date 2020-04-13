using QR.Models;
using QR.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QR.Utils
{
    public class QuestRoomsSeed
    {
        public static List<QuestRoom> GetSeed()
        {
            List<QuestRoom> qrooms = new List<QuestRoom>();

            qrooms.Add( new QuestRoom() 
            { ID = 0, Name = "Apocalipsis", Phone2 = "0972524254", Description = "the word destroyed", Adress = "Getmaskaya 74", Phone1 = "0977112905", FearLvl = 4, HardLvl = 6, DurationTime = 36 });

            qrooms.Add(new QuestRoom() 
            { ID = 1, Name = "DieZone", Phone2 = "0972524254", Description = "Hard lvl of skill", Adress = "Yakira 3", Phone1 = "0977112905", FearLvl = 2, HardLvl = 10, DurationTime = 20 } );

            qrooms.Add(new QuestRoom()
            { ID = 2, Name = "Dinozavre", Phone2 = "", Description = "A lot of dinozavre", Adress = "95 Kvartal", Phone1 = "0977112905", FearLvl = 8, HardLvl = 5, DurationTime = 60 });

            return qrooms;
        }
    }
}