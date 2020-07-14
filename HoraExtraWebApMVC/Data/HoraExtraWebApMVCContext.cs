using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HoraExtraWebApMVC.Models;

namespace HoraExtraWebApMVC.Data
{
    public class HoraExtraWebApMVCContext : DbContext
    {
        public HoraExtraWebApMVCContext (DbContextOptions<HoraExtraWebApMVCContext> options)
            : base(options)
        {
        }

        public DbSet<HoraExtraWebApMVC.Models.Departamento.Departamento> Departamento { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<HorasExtra> HorasExtra { get; set; }
    }
}
