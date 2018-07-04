using DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Contracts
{
    /// <summary>
    /// Contract for databse access
    /// </summary>
   public interface IDataStorage
    {
        event EventHandler<string> Massage;
        List<Shipment> GetShipments();
        List<object> GetShipmentsGroupedBy(bool DateFlag, bool OrganizationFlag, bool CityFlag, bool CoutryFlag, bool ManagerFlag);
    }
}
