using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiSwagger.Models;

namespace ApiSwagger.Data
{
    public class ApiSwaggerContext : DbContext
    {
        public ApiSwaggerContext (DbContextOptions<ApiSwaggerContext> options)
            : base(options)
        {
        }

        public DbSet<ApiSwagger.Models.User> User { get; set; }
    }
}
