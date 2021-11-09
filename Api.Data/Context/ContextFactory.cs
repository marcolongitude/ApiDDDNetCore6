using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    internal class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        
        public MyContext CreateDbContext(string[] args)
        {
            //var connectionString = "Server=172.19.192.1;Data Source=dbApi;Initial Catalog=dbApi;User ID=sa;Password=adminmagti@1981";
            var connectionString = "Server=localhost,1433;Database=dbApi;User ID=sa;Password=adminmagti@1981;Trusted_Connection=false;MultipleActiveResultSets=true";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new MyContext(optionsBuilder.Options);
        }
    }
}
