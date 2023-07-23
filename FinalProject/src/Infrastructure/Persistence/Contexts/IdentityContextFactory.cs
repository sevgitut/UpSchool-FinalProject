//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Design;
//using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

//using Microsoft.EntityFrameworkCore.Infrastructure;

//namespace Infrastructure.Persistence.Contexts
//{
//    public class IdentityContextFactory : IDesignTimeDbContextFactory<IdentityContext>
//    {
//        public IdentityContext CreateDbContext(string[] args)
//        {
//            var optionsBuilder = new DbContextOptionsBuilder<IdentityContext>();
//            var serverVersion= new MySqlServerVersion(1, 1);
//            optionsBuilder.UseMySql("Server=141.98.112.67;Port=7002;Database=sevgi_tut_capstoneproject;Uid= sevgi_tut;Pwd=AG01JaxaCQDsNn554wuzCujCj; ",serverVersion);

//            return new IdentityContext(optionsBuilder.Options);
//        }

//    }
//}
