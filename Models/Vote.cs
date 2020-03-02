using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Pollpular.Models
{
    public class Vote
    {
        [Key]
         public int VoteId { get; set; }
        public int UserId { get; set; } // ApplicationUser.Id
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public int PollId { get; set; }
        public Poll Poll { get; set; }

        public int AnswerId { get; set; }
        public Answer Answer { get; set; }
    }
}