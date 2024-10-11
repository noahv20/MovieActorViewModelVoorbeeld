using System.ComponentModel.DataAnnotations;

namespace MovieActorViewModelVoorbeeld.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        public List<Movie>? Movies { get; set; }
    }
}
