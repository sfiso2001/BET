using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace BET.Models
{
    public class EventDetail
    {
        [Key]
        public int EventDetailID { get; set; }

        public int FK_EventId { get; set; }
        [ForeignKey("FK_EventId")]
        public Event Event { get; set; }

        public int FK_EventDetailStatusID { get; set; }
        [ForeignKey("FK_EventDetailStatusID")]
        public EventDetailStatus EventDetailStatus { get; set; }

        [Required, MaxLength(50)]
        public string EventDetailName { get; set; }
        [Required]
        public int EventDetailNumber { get; set; }

        public decimal EventDetailOdd { get; set; }
        public int FinishingPosition { get; set; }
        public bool FirstTimer { get; set; }

    }
}
