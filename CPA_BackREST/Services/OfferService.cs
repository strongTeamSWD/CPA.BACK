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
            offerRepository = repositoryFactory.GetRepository(typeof(Offer)) as Repository<Offer>;
            geotargetRepository = repositoryFactory.GetRepository(typeof(GeoTarget)) as Repository<GeoTarget>;
            offerRepository.CreateTable();
            
            CreateTestData();
        }

        public void CreateTestData() {
            Offer offer = new Offer();
            offer.Name = "TEEST";
            offer.Description = "TEEST";
            offer.MinLevel = 1l ;
            offer.LevelId = 2l;
            offer.StartDate = DateTime.Today;
            offer.FinishDate = DateTime.Today;

            offerRepository.Add(offer);
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
