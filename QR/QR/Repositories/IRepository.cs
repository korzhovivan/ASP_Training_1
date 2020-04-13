using QR.Models;
using System.Collections.Generic;

namespace QR.Repositories
{
    public interface IRepository
    {
        int Count { get; set; }
        List<QuestRoom> GetAll();
        QuestRoom GetById(int id);
        void Add(QuestRoom item);
        void DeleteById(int id);
        void PushById(QuestRoom obj, int id);
    }
}
