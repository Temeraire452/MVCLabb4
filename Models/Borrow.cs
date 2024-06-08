namespace MVCLabb4.Models
{
    public class Borrow
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int BookId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public Customer Customer { get; set; }
        public Book Book { get; set; }
    }
}
