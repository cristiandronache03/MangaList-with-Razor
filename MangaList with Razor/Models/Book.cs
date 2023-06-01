using System.ComponentModel.DataAnnotations;

namespace MangaList_with_Razor.Models
{
    public class Book
    {
        [Key] 
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;

        public int Volume { get; set; }
    }
}
