using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vega;

namespace CPA_BackREST.Models
{
        [Table(NeedsHistory = false, NoUpdatedOn = true, NoCreatedBy = true, NoCreatedOn = true, NoVersionNo = true, NoIsActive = false, NoUpdatedBy = true)]
        public class GeoTarget : EntityBase
        {
            [PrimaryKey(true)]
            public long Id { get; set; }
            public long CountryId { get; set; }
            public long CityId { get; set; }

            [IgnoreColumn(true)]
            private Country country { get; set; }

            [IgnoreColumn(true)]
            private City city { get; set; }
        }

        [Table(NeedsHistory = false, NoUpdatedOn = true, NoCreatedBy = true, NoCreatedOn = true, NoVersionNo = true, NoIsActive = false, NoUpdatedBy = true)]
        public class Country : EntityBase
        {
            [PrimaryKey(true)]
            [ForeignKey("GeoTarget", "CountryId", false)]
            public long Id { get; set; }
            public string Name { get; set; }
        }

        [Table(NeedsHistory = false, NoUpdatedOn = true, NoCreatedBy = true, NoCreatedOn = true, NoVersionNo = true, NoIsActive = false, NoUpdatedBy = true)]
        public class City : EntityBase
        {
            [PrimaryKey(true)]
            [ForeignKey("GeoTarget", "CountryId", false)]
            public long Id { get; set; }
            public string Name { get; set; }
        }
}
