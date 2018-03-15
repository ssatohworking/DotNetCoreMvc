using Microsoft.EntityFrameworkCore;

namespace _97.DotNetCoreMVC.Models{
  public class MvcMovieContext : DbContext{

    public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
      :base(options)
    {
      
    }

    public DbSet<_97.DotNetCoreMVC.Models.Movie> Movie{get;set;}
  }
}