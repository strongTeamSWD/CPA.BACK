using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CPA_BackREST.Models;
using CPA_BackREST.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CPA_BackREST.Controllers
{

    /*
    public static GET_ALL_OFFERS = "/offers/get-all";
    public static GET_OFFER_BY_ID = "/offers/get-by-id";
    public static CREATE_OFFER = "/offers/create";
    public static DELETE_OFFER_BY_ID = "offers/delete";
         */
    [Route("api/[controller]")]
    public class OffersController
    {
        OfferService offerService;
        public OffersController(OfferService offerService)
        {
            this.offerService = offerService;
        }

        // GET api/offers/get-all
        [HttpGet("get-all")]
        public List<Offer> GetAll()
        {
            return offerService.ReadAllOffers();
        }

        // GET api/offers/get-all
        [HttpGet("get-by-id")]
        public Offer GetById([FromBody] long id)
        {
            return offerService.ReadById(id);
        }

        // POST api/offers/create
        [HttpPost("create")]
        public long CreateOffer([FromBody] Offer offer)
        {
            return offerService.CreateOffer(offer);
        }

        // POST api/offers/delete
        [HttpPost("delete")]
        public bool DeleteOfferById([FromBody] Offer offer)
        {
            return offerService.DeleteOffer(offer,0l);
        }
    }
}
