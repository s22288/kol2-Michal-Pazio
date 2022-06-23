using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Models
{
    public class Membership
    {
        [Key]
        public int MemberID { get; set; }
        [Key]
        public int TeamID { get; set; }
        public DateTime MembershipDate { get; set; }
     [ForeignKey("MemberID")]
        public virtual Member Member { get; set; }
        [ForeignKey("TeamID")]

        public virtual Team Team { get; set; }
    }
}
