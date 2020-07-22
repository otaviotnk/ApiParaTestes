using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APITestes.Models;

namespace APITestes.Data
{
    public class APITestesContext : DbContext
    {
        public APITestesContext (DbContextOptions<APITestesContext> options)
            : base(options)
        {
        }

        public DbSet<APITestes.Models.Curso> Curso { get; set; }

        public DbSet<APITestes.Models.Aula> Aula { get; set; }
    }
}
