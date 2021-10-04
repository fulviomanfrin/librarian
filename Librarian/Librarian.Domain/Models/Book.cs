using System.ComponentModel.DataAnnotations;

namespace Librarian.Models
{
    public class Book
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [StringLength(30)]
        public  string Genre { get; set; }
    }
}
