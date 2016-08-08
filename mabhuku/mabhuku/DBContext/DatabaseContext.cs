using mabhuku.Domain;
using Microsoft.EntityFrameworkCore;

namespace mabhuku.DBContext
{
	public class DatabaseContext : DbContext{
		
		public DbSet<Book> Books{get;set;}

		public DbSet<Rating> Ratings {get;set;}

		public DbSet<Video> Videos {get;set;}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Filename=./ulwazi.db");
		}
	}
}
