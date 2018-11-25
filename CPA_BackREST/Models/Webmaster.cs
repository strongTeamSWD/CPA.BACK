using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vega;

namespace CPA_BackREST.Models {
    [Table(Name = "Users", NoIsActive = false, NoCreatedBy = true, NoCreatedOn = true, NoVersionNo = true)]
    public class Webmaster : EntityBase
    {
        long   UserId { get; set; }
        long   LevelId { get; set; }
        bool   IsActive { get; set; }
    }
}
