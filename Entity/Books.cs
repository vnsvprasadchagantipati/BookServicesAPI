using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookServicesAPI.Entity
{
    public class Books
    {
        [Key]
        [Column("BookId", TypeName = "varchar")]
        [Required]
        [StringLength(20)]
        public string? BookId {  get; set; }

        [Required]
        [StringLength(50)]
        [Column("Bookname", TypeName = "varchar")]
        public string? BookName { get; set; }

        [Required]
        [StringLength(20)]
        [Column("Writer", TypeName = "varchar")]
        public string? Author { get; set;}

        [Required]
        public DateTime ReleaseDate { get; set; }
       
        public double? price { get; set; }
        public string? Language { get; set; }
    }
}
