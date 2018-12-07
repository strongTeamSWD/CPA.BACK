using CPA_BackREST.DB;
using CPA_BackREST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vega;

namespace CPA_BackREST.Services
{
    public class OfferService 
    {
        RepositoryFactory repositoryFactory;

        Repository<Offer> offerRepository;
        Repository<GeoTarget> geotargetRepository;

        public OfferService(RepositoryFactory repositoryFactory)
        {
            this.repositoryFactory = repositoryFactory;
        }

        public long CreateOffer(Offer newOffer)
        {
            return (long)offerRepository.Add(newOffer);
        }

        public Offer ReadById(long id)
        {
            return offerRepository.ReadOne(id);
        }

        public List<Offer> ReadAllOffers()
        {
            return offerRepository.ReadAll().ToList();
        }

        public bool UpdateOffer(Offer offer)
        {
            return offerRepository.Update(offer);
        }

        public bool DeleteOffer(Offer offer, long uid)
        {
            return offerRepository.Delete(offer, uid);
        }
    }
}
