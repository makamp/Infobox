using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infobox.Models
{
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public virtual UserProfile User { get; set; }

        public bool? IsPositive { get; set; }

        public int AuthorVote { get; set; }

        public int UsersPositiveVotes { get; set; }

        public int UsersNegativeVotes { get; set; }

        public virtual string Content { get; set; }

        public virtual Film Film { get; set; }
    }
}