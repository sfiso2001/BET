using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ChickenStore.Models
{
    public class EmailMessage
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [Required, DisplayName("Subject")]
        public string Subject { get; set; }
        [Required]
        [MaxLength(300)]
        [DisplayName("Message")]
        public string MessageText { get; set; }
        [Required, DisplayName("Contact Name")]
        [MaxLength(50)]
        public string FromName { get; set; }
        [Required, DisplayName("Contact email")]
        [EmailAddressAttribute]
        [MaxLength(50)]
        public string FromEMail { get; set; }
        public bool? Sent { get; set; }
        [DisplayName("Sent")]
        public DateTime? SentDate { get; set; }
        public bool? Resolved { get; set; }
        public DateTime? ResolvedDate { get; set; }
        [MaxLength(50)]
        public string ResolvedBy {get; set; }
    }
}
