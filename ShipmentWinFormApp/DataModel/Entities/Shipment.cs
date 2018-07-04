using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Entities
{
    /// <summary>
    /// Shipment entity
    /// </summary>
   public class Shipment
    {
        [Key]
        [System.ComponentModel.Browsable(false)]
        public int Id { get; set; }
        [System.ComponentModel.DisplayName("Дата")]
        public DateTime? Date { get; set; }
        [System.ComponentModel.DisplayName("Организация")]
        public string Organization { get; set; }
        [System.ComponentModel.DisplayName("Город")]
        public string City { get; set; }
        [System.ComponentModel.DisplayName("Страна")]
        public string Country { get; set; }
        [System.ComponentModel.DisplayName("Менеджер")]
        public string Manager { get; set; }
        [System.ComponentModel.DisplayName("Количество")]
        public int Quantity { get; set; }
        [System.ComponentModel.DisplayName("Сумма")]
        public double Amount { get; set; }
    }
}
