﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiWebApplication.Controllers
{
    public class AuctionHouseController : ApiController
    {
        //// GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

        public List<Models.AuctionItem> GetAllAuctions()
        {
            return Models.AuctionHouseData.GetAllAuctions();
        }

        public Models.AuctionItem GetAuction(int itemNumber)
        {
            return Models.AuctionHouseData.GetAuction(itemNumber);
        }

        public void BidOnProduct(Models.Bid bid)
        {
            Models.AuctionHouseData.BidOnAuction(bid);
        }
    }
}