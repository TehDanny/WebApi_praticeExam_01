using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApiWebApplication.Models
{
    public class Bid
    {
        public int ItemNumber { get; set; }
        public decimal Price { get; set; }
        public string CustomName { get; set; }
        public int CustomPhone { get; set; }

        public Bid(int itemNumber, decimal price, string customName, int customPhone)
        {
            ItemNumber = itemNumber;
            Price = price;
            CustomName = customName;
            CustomPhone = customPhone;
        }
    }
}