 using System.ComponentModel.DataAnnotations;

    namespace BookStore.Models
    {
        public class Book
        {
            public int Id { get; set; }

            [Required]
            public required string Title { get; set; }

            [Required]
            public required string Author { get; set; }

            [Required]
            public required string Genre { get; set; }

            [Required]
            [DataType(DataType.Currency)]
            public decimal Price { get; set; }

            public DateTime PublishDate { get; set; }
        }
    }


