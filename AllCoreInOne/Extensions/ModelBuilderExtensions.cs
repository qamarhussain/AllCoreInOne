using AllCoreInOne.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace AllCoreInOne.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new List<Department>()
                {
                    new Department{Id = Guid.NewGuid(),Name="Computer Science"},
                    new Department{Id = Guid.NewGuid(),Name="Business Administration"},
                    new Department{Id = Guid.NewGuid(),Name="Physics"}
                }
                );
        }
    }
}
