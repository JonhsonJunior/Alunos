using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AulaSub.Models;

namespace AulaSub.Data
{
    public class AulaSubContext : DbContext
    {
        public AulaSubContext (DbContextOptions<AulaSubContext> options)
            : base(options)
        {
        }

        public DbSet<AulaSub.Models.Aluno> Aluno { get; set; } = default!;
    }
}
