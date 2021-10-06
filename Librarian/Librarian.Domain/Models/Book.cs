using System.ComponentModel.DataAnnotations;
using Domain.Models.Base;

namespace Domain.Models
{
    public class Book : BaseEntity
    {
        [Key]
        [Required]
        public new int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [StringLength(30)]
        public  string Genre { get; set; }
    }
}
