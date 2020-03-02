using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Pollpular.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}
        [Required]
        [MinLength(2, ErrorMessage="Name must be 2 characters or longer")]
        public string FirstName {get;set;}
        [Required]
        [MinLength(2, ErrorMessage="Name must be 2 characters or longer")]
        [Display(Name="First Name")]
        public string LastName {get;set;}
        [Required]
        [MinLength(2, ErrorMessage="Name must be 2 characters or longer")]
        [MaxLength(15)]
        [Display(Name="Last Name")]
        public string Username {get;set;}
        [Required]
        [EmailAddress]
        public string Email {get;set;}
        [Required]
        [MinLength(8, ErrorMessage="Password must be 8 characters or longer")]
        [DataType(DataType.Password)]
        public string Password {get;set;}
        [NotMapped]
        [Compare("Password",ErrorMessage="Confirm password does not match password")]
        [DataType(DataType.Password)]
        public string Confirm {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public List<Poll> Polls { get; set; }
        public List<Vote> Votes { get; set; }
    }
}