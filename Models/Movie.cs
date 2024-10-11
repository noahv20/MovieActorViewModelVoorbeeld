using System.ComponentModel.DataAnnotations;

namespace MovieActorViewModelVoorbeeld.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }
        public List<Actor>? Actors { get; set; }
    }
}
