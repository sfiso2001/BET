using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BET.Models
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }
        [Required]
        [MaxLength(100)]
        public string EventName { get; set; }
        [Required]
        public int FK_TournamentId { get; set; }
        [ForeignKey("FK_TournamentId")]
        public Tournament Tournament { get; set; }

        [Required]
        public int EventNumber { get; set; }
        public DateTime EventDateTime { get; set; }
        public DateTime EventEndDateTime { get; set; }
        public bool AutoClose { get; set; }

    }
}
