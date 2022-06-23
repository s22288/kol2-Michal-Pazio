using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        public int OrganizationID { get; set; }
        public string MemberName { get; set; }
        public string MemberSurname { get; set; }
        public string MemberNickName{get;set;}
        [ForeignKey("OrganizationID")]
        public virtual Organization Organization { get; set; }
        public virtual ICollection<Membership> Memberships { get; set; }

    }
}
