using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiWebApplication.Models
{
    public class AuctionItem
    {
        public int ItemNumber { get; set; }
        public string ItemDescription { get; set; }
        public decimal RatingPrice { get; set; }
        public decimal BidPrice { get; set; }
        public string BidCustomName { get; set; }
        public int BidCustomPhone { get; set; }
        public DateTime BidTimestamp { get; set; }

        public AuctionItem(int itemNumber, string itemDescription, decimal ratingPrice, decimal bidPrice, string bidCustomName, int bidCustomPhone, DateTime bidTimestamp)
        {
            ItemNumber = itemNumber;
            ItemDescription = itemDescription;
            RatingPrice = ratingPrice;
            BidPrice = bidPrice;
            BidCustomName = bidCustomName;
            BidCustomPhone = bidCustomPhone;
            BidTimestamp = bidTimestamp;
        }

        static internal void HardcodeProducts()
        {
            AuctionItem p1 = new AuctionItem(1, "Brugt cykel", 1000.00M, 500.00M, "Daniel Alexander Nedergaard", 12345678, DateTime.Now);
            AuctionItem p2 = new AuctionItem(2, "Smart ny bil", 50000.00M, 75000.00M, "Bjørk", 87654321, DateTime.Now);
            AuctionHouseData.AddProduct(p1);
            AuctionHouseData.AddProduct(p2);
        }
    }
}