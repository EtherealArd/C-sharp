using DataModel.Entities;
using DataModel.MSSQLServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    /// <summary>
    /// Class serves for create and initial database
    /// </summary>
   public class DatabaseInitial:System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            base.Seed(context);
            context.Shipment.Add(new Shipment() { Id = 1, Date = new DateTime(2018,7,2), Organization = "Восход", City = "Киев", Country = "Украина", Manager = "Иванов", Quantity = 1, Amount = 100 });
            context.Shipment.Add(new Shipment() { Id = 2, Date = new DateTime(2018,7,2), Organization = "РиК", City = "Москва", Country = "Россия", Manager = "Петров", Quantity = 2, Amount = 250 });
            context.Shipment.Add(new Shipment() { Id = 3, Date = new DateTime(2018,7,2), Organization = "РиК", City = "Москва", Country = "Россия", Manager = "Петров", Quantity = 5, Amount = 450 });
            context.Shipment.Add(new Shipment() { Id = 4, Date = new DateTime(2018, 7, 2), Organization = "Восход", City = "Киев", Country = "Украина", Manager = "Иванов", Quantity = 7, Amount = 750 });
            context.Shipment.Add(new Shipment() { Id = 5, Date = new DateTime(2018, 7, 3), Organization = "РиК", City = "Москва", Country = "Россия", Manager = "Сидоров", Quantity = 10, Amount = 1050 });
            context.Shipment.Add(new Shipment() { Id = 6, Date = new DateTime(2018, 7, 3), Organization = "Фриз", City = "Минск", Country = "Беларусь", Manager = "Лукашенко", Quantity = 8, Amount = 850 });
            context.SaveChanges();
        }
    }
}
