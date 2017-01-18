using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApiWebApplication.Models
{
    public class AuctionHouseData
    {
        private static List<AuctionItem> ItemList = new List<AuctionItem>();
        private static object myLock = new object();

        internal static void AddProduct(AuctionItem p)
        {
            ItemList.Add(p);
        }

        internal static List<AuctionItem> GetAllProducts()
        {
            if (ItemList.Count == 0)
                AuctionItem.HardcodeProducts();

            return ItemList;
        }

        internal static AuctionItem GetProduct(int itemNumber)
        {
            if (ItemList.Count == 0)
                AuctionItem.HardcodeProducts();

            lock (myLock)
            {
                foreach (var item in ItemList)
                {
                    if (item.ItemNumber == itemNumber)
                        return item;
                }
            }

            return null;
        }

        internal static void BidOnProduct(Bid bid)
        {
            lock (myLock)
            {
                bool itemExists = false;
                foreach (var item in ItemList)
                {
                    if (bid.ItemNumber == item.ItemNumber)
                    {
                        itemExists = true;
                        if (bid.Price > item.BidPrice)
                        {
                            item.BidPrice = bid.Price;
                            item.BidCustomName = bid.CustomName;
                            item.BidCustomPhone = bid.CustomPhone;
                        }
                            
                        else
                            throw new Exception("Bid is too low.");
                    }
                }
                if (itemExists == false)
                    throw new Exception("Product doesn't exist.");
            }
        }
    }
}