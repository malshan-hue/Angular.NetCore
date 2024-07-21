using Angular.NetCore.Server.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Angular.NetCore.Server.Data
{
    public class ContactDbContext : DbContext
    {
        public ContactDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }
    }
}
