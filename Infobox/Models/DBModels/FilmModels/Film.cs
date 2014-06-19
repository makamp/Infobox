using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infobox.Models
{
    public class Film
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string OriginalTitle { get; set; }

        public string Slogan { get; set; }

        public string Description { get; set; }

        public virtual Country Country { get; set; }

        public virtual Person Director { get; set; }

        public virtual Person Producer { get; set; }

        public virtual Person Composer { get; set; }

        public virtual Person Operator { get; set; }

        public virtual Person Writer { get; set; }

        public DateTime WorldReleaseDate { get; set; }
        public DateTime RuReleaseDate { get; set; }

        public DateTime DVDReleaseDate { get; set; }
        public DateTime BDReleaseDate { get; set; }

        public MPAARate MPAARate { get; set; }

        public int AgeLimit { get; set; }

        public TimeSpan Runtime { get; set; }

        public int Budget { get; set; }

        public int Marketing { get; set; }

        public int USAFees { get; set; }
        public int RuFees { get; set; }
        public int WorldFees { get; set; }

        public double Rating { get; set; }
        public int Votes { get; set; }

        public virtual ICollection<Person> RolesDuplicators { get; set; }

        public virtual ICollection<Person> Montagers { get; set; }

        public virtual ICollection<Person> Painters { get; set; }

        public virtual ICollection<Company> Companies { get; set; }

        public virtual ICollection<Person> Stars { get; set; }

        public virtual ICollection<Genre> Genres { get; set; }

        public virtual ICollection<Keyword> Keywords { get; set; }

        public virtual ICollection<OfficialSite> OfficialSites { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}