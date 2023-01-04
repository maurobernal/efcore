
using Microsoft.EntityFrameworkCore;

public class BlogDBContext : DbContext
{
    public DbSet<Blog> Blogs {get;set;}
    public DbSet<Post> Posts {get;set;}

public string DBPath {get;}
    public BlogDBContext()
    {
        var folder= Environment.SpecialFolder.LocalApplicationData;
        var path= Environment.GetFolderPath(folder);

        DBPath= System.IO.Path.Join(path, "blog.db");
    }

 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)=> 
 optionsBuilder.UseSqlite($"Data Source={DBPath}");
       


}