namespace chrsolr_api.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options) { }

    public DbSet<Social> Socials => Set<Social>();
    public DbSet<BlogPost> BlogPosts => Set<BlogPost>();
}
