using Microsoft.EntityFrameworkCore;

namespace RAZORWEB.Models
{
	public class MyBlogContext : DbContext
	{
        public DbSet<Article> articles { get; set; }
        public MyBlogContext(DbContextOptions<MyBlogContext> options) : base(options)
		{
			
		}

		protected override void OnConfiguring(DbContextOptionsBuilder builder)
		{
			base.OnConfiguring(builder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}



		
		
	}
}
