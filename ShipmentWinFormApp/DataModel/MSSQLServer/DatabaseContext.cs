using DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.MSSQLServer
{
    /// <summary>
    /// Context for database access 
    /// </summary>
    public class DatabaseContext : DbContext
    {
        public DbSet<Shipment> Shipment { get; set; }

        /// <summary>
        /// Sets initial class from which database will be filled
        /// </summary>
        public DatabaseContext() : base("ConnectionString")
        {
            Database.SetInitializer<DatabaseContext>(new DatabaseInitial());
        }   
    }
}
