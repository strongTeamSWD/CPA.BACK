using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vega;

namespace CPA_BackREST.Models
{
    [Table(NeedsHistory = false, NoUpdatedOn= true,NoCreatedBy = true, NoCreatedOn = true, NoVersionNo = true, NoIsActive = false,NoUpdatedBy = true)]
    public class Users : EntityBase
    {

        //   [ForeignKey("Source","UserId",true)]
        //   [ForeignKey("Webmaster","UserId",true)]
        [PrimaryKey(true)]
        public long     Id { get; set; }
        public long     Gender_id { get; set; }
        
        public long     RoleId { get; set; }

        public string   Login { get; set; }
        public string   Password { get; set; }
        public string   Name { get; set; }
        public string   Surname { get; set; }
        public DateTime Birth_date { get; set; }
        public string   Email { get; set; }
        public string   PhoneNumber { get; set; }

        public override bool IsActive { get; set; }
    }
}
