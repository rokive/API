using Entity.Models;
using Microsoft.Extensions.DependencyInjection;
using Repositorys.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<ApiDbContext>();
            context.Database.EnsureCreated();
            if (!context.Categorys.Any())
            {
                context.Categorys.Add(new Category() { CategoryName = "test1"});
                context.Categorys.Add(new Category() { CategoryName = "test2"});
                context.SaveChanges();
            }
        }
    }
}
