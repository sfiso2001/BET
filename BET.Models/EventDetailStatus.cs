using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace BET.Models
{
    public class EventDetailStatus
    {
        [Key]
        public int EventDetailStatusID { get; set; }
        [Required]
        [MaxLength(50)]
        public string EventDetailStatusName { get; set; }
    }
}
