using Microsoft.EntityFrameworkCore;
using Repositorys.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    public static class DbInitializer
    {
        public static void Initialize(ApiDbContext context)
        {
            context.Database.Migrate();

            // Add Seed Data...
        }
    }
}
