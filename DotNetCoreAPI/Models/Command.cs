using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreAPI.Models
{
    public class Command
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [MaxLength(250)]
        public string HowTo { get; set; }
        public string Line { get; set; }
        [Required]
        public string Platform { get; set; }

        public DateTime? DateCreated { get; set; }
    }
}
