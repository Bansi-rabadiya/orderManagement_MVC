using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using static OrderManagement_mvc_Common.Common;

namespace orderManagement_MVC.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public string OrderName { get; set; }
        [Display(Name = "OrderDate")]
        [Required]
        public DateTime OrderDate { get; set; }

        public OrderStatus orderStatus { get; set; }
         public decimal TotalAmount()
        {
            return 10000;
        }
    }
}