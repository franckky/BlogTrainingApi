using Microsoft.EntityFrameworkCore;

namespace BlogTraining.Entities
{
    public class BlogTrainingDbContext : DbContext
    {
        public BlogTrainingDbContext(DbContextOptions<BlogTrainingDbContext> options)
            : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }
    }
}
