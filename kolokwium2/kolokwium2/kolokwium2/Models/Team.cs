using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public int OrganizationID { get; set; }
        public string TeamName { get; set; }
        public string TeamDescription { get; set; }
        public virtual ICollection<File> Files { get; set; }
        [ForeignKey("OrganizationID")]
        public virtual Organization Organization { get; set; }
        public virtual ICollection<Membership> Memberships { get; set; }

    }
}
