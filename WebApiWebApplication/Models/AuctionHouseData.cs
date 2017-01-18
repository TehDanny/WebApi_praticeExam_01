using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApiWebApplication.Models
{
    public class AuctionHouseData
    {
        private static List<AuctionItem> AuctionList = new List<AuctionItem>();
        private static object myLock = new object();

        internal static void AddAuction(AuctionItem p)
        {
            AuctionList.Add(p);
        }

        internal static List<AuctionItem> GetAllAuctions()
        {
            if (AuctionList.Count == 0)
                AuctionItem.HardcodeAuctions();

            return AuctionList;
        }

        internal static AuctionItem GetAuction(int itemNumber)
        {
            if (AuctionList.Count == 0)
                AuctionItem.HardcodeAuctions();

            lock (myLock)
            {
                foreach (var item in AuctionList)
                {
                    if (item.ItemNumber == itemNumber)
                        return item;
                }
            }

            return null;
        }

        internal static void BidOnAuction(Bid bid)
        {
            lock (myLock)
            {
                bool auctionExists = false;
                foreach (var item in AuctionList)
                {
                    if (bid.ItemNumber == item.ItemNumber)
                    {
                        auctionExists = true;
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
                if (auctionExists == false)
                    throw new Exception("Auction doesn't exist.");
            }
        }
    }
}