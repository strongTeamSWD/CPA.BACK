using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vega;

namespace CPA_BackREST.Models
{
    [Table(NeedsHistory = false, NoUpdatedOn = true, NoCreatedBy = true, NoCreatedOn = true, NoVersionNo = true, NoIsActive = false, NoUpdatedBy = true)]
    public class Source : EntityBase
    {
        [PrimaryKey(true)]
        public long Id { get; set; }
        public long UserId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public long TypeId { get; set; }
    }
}
