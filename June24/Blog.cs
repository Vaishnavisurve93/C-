using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloggingSystem.Models
{
    [Table("Blogs")]
    public class Blog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int BlogId { get; set; }

        [Required]
        [MaxLength(200)]
        [Column("BlogName", Order = 2)]
        public string Name { get; set; }

        [Required]
        [MaxLength(500)]
        [Column("BlogUrl", Order = 3)]
        public string Url { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
