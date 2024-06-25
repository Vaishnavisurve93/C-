using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloggingSystem.Models
{
    [Table("Posts")]
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int PostId { get; set; }

        [Required]
        [MaxLength(200)]
        [Column(Order = 2)]
        public string Title { get; set; }

        [Required]
        [Column(Order = 3)]
        public string Content { get; set; }

        [Column(Order = 4)]
        public DateTime PublishedDate { get; set; }

        [ForeignKey("Blog")]
        [Column(Order = 5)]
        public int BlogId { get; set; }

        public Blog Blog { get; set; }
    }
}
