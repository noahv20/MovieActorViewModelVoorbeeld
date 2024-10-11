using Microsoft.EntityFrameworkCore;
using MovieActorViewModelVoorbeeld.Models;
namespace MovieActorViewModelVoorbeeld.Data

{
    public class ActorMovieDb : DbContext 
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn = "Data Source=.;Initial Catalog=ActorMovieDb;Integrated Security=True; TrustServerCertificate=true;";
            optionsBuilder.UseSqlServer(conn);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasMany(a => a.Actors)
                .WithMany(a => a.Movies);

            modelBuilder.Entity<Actor>()
                .Property(a => a.Name)
                .HasMaxLength(50);

            modelBuilder.Entity<Movie>()
                .Property(m => m.Title)
                .HasMaxLength(50);

            Actor actor = new Actor()
            {
                Id = 1,
                Name = "bart",
                BirthDate = new DateTime(2000, 2, 23)
            };
            Movie movie = new Movie()
            {
                Id = 1,
                Title = "Star Wars",
                Genre = "Fiction"
            };

            modelBuilder.Entity<Actor>()
                .HasData(actor);
            modelBuilder.Entity<Movie>()
                .HasData(movie);

            base.OnModelCreating(modelBuilder);
        }
    }
}
