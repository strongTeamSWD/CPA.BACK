using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vega;

namespace CPA_BackREST.Models
{
    [Table(NeedsHistory = false, NoUpdatedOn = true, NoCreatedBy = true, NoCreatedOn = true, NoVersionNo = true, NoIsActive = false, NoUpdatedBy = true)]
    public class SourceType : EntityBase
    {
        [PrimaryKey(true)]
        [ForeignKey("Source", "TypeId",true)]
        public long Id { get; set; }
        public string Name { get; set; }
        public string IsActive { get; set;}
    }
}
