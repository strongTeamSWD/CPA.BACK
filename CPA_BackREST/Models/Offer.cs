using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vega;

namespace CPA_BackREST.Models
{
    [Table(NeedsHistory = false, NoUpdatedOn = true, NoCreatedBy = true, NoCreatedOn = true, NoVersionNo = true, NoIsActive = false, NoUpdatedBy = true)]
    public class Offer : EntityBase
    {
        [ForeignKey]
        [PrimaryKey(true)]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Aim> aims { get; set;}
        public List<GeoTarget> geoTargets {get;set;}


        public bool IsActive { get; set; }
        public long MinLevel { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
    }

    [Table(NeedsHistory = false, NoUpdatedOn = true, NoCreatedBy = true, NoCreatedOn = true, NoVersionNo = true, NoIsActive = false, NoUpdatedBy = true)]
    public class GeoTarget
    {

    }

[Table(NeedsHistory = false, NoUpdatedOn = true, NoCreatedBy = true, NoCreatedOn = true, NoVersionNo = true, NoIsActive = false, NoUpdatedBy = true)]
    public class Aim
    {
        [PrimaryKey(true)]
        public long Id { get; set; }
        
        public long OfferID { get; set; }

        public string Name { get; set; }
        public float Payment { get; set; }
        public long ProcessingDays { get; set; }
        public long PostClickDays { get; set; }
        public long AcceptRate { get; set; }
    }
}
