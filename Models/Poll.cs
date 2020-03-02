using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Pollpular.Models
{
    public class Poll
    {
        [Key]
        public int PollId { get; set; } // primary key by ef core conventions
        public string Question { get; set; }
        public List<Answer> Answers { get; set; } // cascade on delete by ef core conventions
        public int UserId { get; set; } // User.Id
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}