using CoffeeShop.DAO.Impl.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CoffeeShop.DAO.Impl.DataContext
{
    public class CoffeeShopAppContext:DbContext
    {
        public CoffeeShopAppContext(DbContextOptions<CoffeeShopAppContext> options):base(options) { }
        public DbSet<DrinkDAO> DrinkDAOs { get; set; }
        public DbSet<IngredientDAO> IngredientDAOs { get; set; }
        public DbSet<MachineDAO> MachineDAOs { get; set; }
        public DbSet<MachineIngredientDAO> MachineIngredientDAOs { get; set; }
        public DbSet<MachineServesDAO> MachineServesDAOs { get; set; }
        public DbSet<RecipeDAO> RecipeDAOs { get; set; }

    }
    public class DbContextFactory : IDesignTimeDbContextFactory<CoffeeShopAppContext>
    {
        public CoffeeShopAppContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CoffeeShopAppContext>();
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = CoffeeShop; Trusted_Connection = True");

            return new CoffeeShopAppContext(optionsBuilder.Options);
        }
    }
}
