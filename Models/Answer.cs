using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Pollpular.Models
{
    public class Answer
    {
        [Key]
        public int AnswerId { get; set; } // primary key by ef core conventions
        public string Description { get; set; }
        public int Votes { get; set; }
        public Poll Poll { get; set; }
    }
}