using AtlasFoxAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace AtlasFoxAPI
{
    public class _DbContext: DbContext
    {
        public _DbContext(DbContextOptions<_DbContext> options)
            : base(options)
        {
        }

        public DbSet<FormDetail> FormDetail { get; set; }   

        //public DbSet<FormPPK> FormPPK { get; set; }

        public DbSet<FormInfo> FormInfo { get; set; }
    }
}
