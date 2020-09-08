using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BET.Models
{
    public class Tournament
    {
        [Key]
        public int TournamentID { get; set; }
        [Required]
        [MaxLength(200)]
        public string TournamentName { get; set; }
    }
}
