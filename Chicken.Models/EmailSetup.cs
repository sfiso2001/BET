using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ChickenStore.Models
{
    public class EmailSetup
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string mailserver { get; set; }
        [Required]
        [MaxLength(50)]
        public string username { get; set; }
        [MaxLength(50)]
        public string pwd { get; set; }
        [MaxLength(50)]
        public string displayname { get; set; }
        [MaxLength(20)]
        public string emailtype { get; set; }
    }
}
