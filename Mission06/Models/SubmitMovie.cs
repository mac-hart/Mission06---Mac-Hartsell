using System.ComponentModel.DataAnnotations;

namespace Mission06.Models
{
    public class SubmitMovie
    {
        [Key]
        public int Id { get; set; }
        // Category
        public string Category { get; set; }

        // Title
        public string Title { get; set; }

        // Year
        public int Year { get; set; }

        // Director
        public string Director { get; set; }

        // Rating
        public string Rating { get; set; }

        // Edited
        public bool? Edited { get; set; }

        // Lent To
        public string? LentTo { get; set; }

        // Notes
        public string? Notes { get; set; }
    }
}
