using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CadastroListagemOak.Models;

namespace CadastroListagemOak.Data
{
    public class CadastroListagemOakContext : DbContext
    {
        public CadastroListagemOakContext (DbContextOptions<CadastroListagemOakContext> options)
            : base(options)
        {
        }

        public DbSet<CadastroListagemOak.Models.Cadastro> Cadastro { get; set; } = default!;
    }
}
