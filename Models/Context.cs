using Microsoft.EntityFrameworkCore;

namespace Pollpular.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) { }
        public DbSet<User> Users {get;set;}
        public DbSet<Poll> Polls {get;set;}
        public DbSet<Vote> Votes {get;set;}
        public DbSet<Answer> Answers {get;set;}
    }
}