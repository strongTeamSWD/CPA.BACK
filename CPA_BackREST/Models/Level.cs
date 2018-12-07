using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vega;

namespace CPA_BackREST.Models
{
    [Table(NeedsHistory = false, NoUpdatedOn = true, NoCreatedBy = true, NoCreatedOn = true, NoVersionNo = true, NoIsActive = false, NoUpdatedBy = true)]
    public class Level : EntityBase
    {
        [PrimaryKey(true)]
        [ForeignKey("Webmaster", "LevelId", true)]
        [ForeignKey("Offer", "LevelId", true)]
        public long Id { get; set; }
        public string Name { get; set; }

    }
}
