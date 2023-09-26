using Microsoft.EntityFrameworkCore;
using MinimalAPIPostgresSQLEF.Model;

namespace MinimalAPIPostgresSQLEF.Data
{
    public class OfficeDb: DbContext
    {
        public OfficeDb(DbContextOptions<OfficeDb> options): base(options) 
        {

        }
        public DbSet<Employee> Employees => Set<Employee>();
    }
}
