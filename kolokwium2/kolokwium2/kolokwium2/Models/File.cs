using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Models
{
    public class File
    {
        public int FieleID { get; set; }
        public int TeamID { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public int FileSize { get; set; }
        [ForeignKey("TeamID")]
        public virtual Team Team { get; set; }
    }
}
