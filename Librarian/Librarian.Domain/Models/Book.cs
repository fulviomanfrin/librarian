using Domain.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Book : BaseEntity
    {
        
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [StringLength(30)]
        public  string Genre { get; set; }
    }
}
