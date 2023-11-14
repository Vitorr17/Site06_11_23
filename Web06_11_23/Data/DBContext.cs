using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web06_11_23.Models;

namespace Web06_11_23.Data
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<Web06_11_23.Models.Consulta> Consulta { get; set; } = default!;

        public DbSet<Web06_11_23.Models.Paciente> Paciente { get; set; } = default!;
    }
}
