using Microsoft.EntityFrameworkCore;
using ASP.NETCoreWebAPICRUDWithEntityFramework.Models;

namespace ASP.NETCoreWebAPICRUDWithEntityFramework.Data
{
	public class ContactsAPIDbContext : DbContext
	{
        public ContactsAPIDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Contact> Contact { get; set; } 
    }
}
