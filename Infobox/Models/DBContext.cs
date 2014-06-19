using System.Data.Entity;

namespace Infobox.Models
{
    public class DBContext : DbContext
    {
        public DBContext() : base("DefaultConnection")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Keyword> Keywords { get; set; }
        public DbSet<MPAARate> MPAARates { get; set; }
        public DbSet<OfficialSite> OfficialSites { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonType> PersonTypes { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}