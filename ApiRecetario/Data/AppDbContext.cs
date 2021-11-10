using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRecetario.Models;

namespace ApiRecetario.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<ApiRecetario.Models.Departamento> Departamento { get; set; }
        public DbSet<ApiRecetario.Models.Receta> Receta { get; set; }

    }
}
