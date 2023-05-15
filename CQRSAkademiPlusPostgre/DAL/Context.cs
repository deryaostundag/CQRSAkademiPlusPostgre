using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace CQRSAkademiPlusPostgre.DAL
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options): base(options)
        {
                
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
