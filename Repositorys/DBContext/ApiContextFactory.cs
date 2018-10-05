using Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorys.DBContext
{
    public class ApiContextFactory : IDesignTimeDbContextFactory<ApiDbContext>
    {
        public ApiContextFactory()
        {
        }


        public ApiDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ApiDbContext>();
            builder.UseSqlServer(Globals.connection_string_name,b=>b.MigrationsAssembly("API"));
            //builder.UseSqlServer(Globals.connection_string_name);
            return new ApiDbContext(builder.Options);
        }
        
    }
}
