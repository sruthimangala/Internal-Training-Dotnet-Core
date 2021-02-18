using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Director> Director { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MovieDetails> MovieDetails { get; set; }
        

    }
}