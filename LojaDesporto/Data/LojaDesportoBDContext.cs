using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LojaDesporto.Models;

namespace LojaDesporto.Data
{
    public class LojaDesportoBDContext : DbContext
    {
        public LojaDesportoBDContext (DbContextOptions<LojaDesportoBDContext> options)
            : base(options)
        {
        }

        public DbSet<LojaDesporto.Models.Produto> Produto { get; set; }
    }
}
