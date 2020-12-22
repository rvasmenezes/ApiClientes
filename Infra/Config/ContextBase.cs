using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Config
{
    public class ContextBase : DbContext
    {

        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {

        }
     
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(StringConnectionConfig());
            }
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }

        private string StringConnectionConfig()
        {
            string strConf = "server=servidor01\\SQLEXPRESS,1433;User Id=sa;password=server@01;Persist Security Info=True;database=DDDTesteCore";
            return strConf;
        }
    }
}
