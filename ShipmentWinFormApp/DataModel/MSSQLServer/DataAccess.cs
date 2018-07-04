using DataModel.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel.Entities;

namespace DataModel.MSSQLServer
{
  public class DataAccess : IDataStorage
    {

        private DatabaseContext context = new DatabaseContext();//Context for database access

        public event EventHandler<string> Massage;

        protected virtual void OnMasssegeChanged(string massage)
        {
            Massage?.Invoke(this, massage);
        }

        /// <summary>
        /// Method casts data from database to List of Shipment
        /// </summary>
        /// <returns>All shipment data from database</returns>
        public List<Shipment> GetShipments()
        {
            try
            {
                return context.Shipment.ToList<Shipment>();
            }
            catch (Exception e)
            {
                OnMasssegeChanged(e.Message);
            }
            return null;
        }
        /// <summary>
        /// Dynamic query for grouping data
        /// </summary>
        /// <param name="DateFlag"></param>
        /// <param name="OrganizationFlag"></param>
        /// <param name="CityFlag"></param>
        /// <param name="CoutryFlag"></param>
        /// <param name="ManagerFlag"></param>
        /// <returns></returns>
        public List<object> GetShipmentsGroupedBy(bool DateFlag, bool OrganizationFlag, bool CityFlag, bool CoutryFlag, bool ManagerFlag)
        {
            try
            {
                var groupedData = context.Shipment.Select(i =>
                new
                {
                    Date = DateFlag ? i.Date : null,
                    Organization = OrganizationFlag ? i.Organization : null,
                    City = CityFlag ? i.City : null,
                    Country = CoutryFlag ? i.Country : null,
                    Manager = ManagerFlag ? i.Manager : null,
                    Quantity = i.Quantity,
                    Amount = i.Amount
                }).GroupBy(g => new { g.Date, g.Organization, g.City, g.Country, g.Manager }, g => new { g.Quantity, g.Amount }).Select(i =>
                        new
                        {
                            Date = i.Key.Date,
                            Organization = i.Key.Organization,
                            City = i.Key.City,
                            Country = i.Key.Country,
                            Manager = i.Key.Manager,
                            Quantity = i.Sum(c => c.Quantity),
                            Amount = i.Sum(c => c.Amount),
                        });

                return groupedData.ToList<object>();
            }
            catch (Exception e)
            {
                OnMasssegeChanged(e.Message);
            }
            return null;      
        }
    }
}
