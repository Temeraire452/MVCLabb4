using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCLabb4.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Titel")]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Författare")]
        public string Author { get; set; }

        public bool IsReturned { get; set; }

        public ICollection<Borrow> Borrows { get; set; }
    }
}
