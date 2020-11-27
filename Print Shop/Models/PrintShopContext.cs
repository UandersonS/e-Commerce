using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Print_Shop.Models
{
    public class PrintShopContext : DbContext
    {
        public PrintShopContext() : base("DefaultConnection")
        {

        }

        //Desabilita as Cascatas(Exclusao de referencias)
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
        
        public System.Data.Entity.DbSet<Print_Shop.Models.Departaments> Departaments { get; set; }

        public System.Data.Entity.DbSet<Print_Shop.Models.City> Cities { get; set; }

        public System.Data.Entity.DbSet<Print_Shop.Models.Company> Companies { get; set; }

        public System.Data.Entity.DbSet<Print_Shop.Models.User> Users { get; set; }
        public object TaxPaers { get; internal set; }

        public System.Data.Entity.DbSet<Print_Shop.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<Print_Shop.Models.Tax> Taxes { get; set; }
    }
}