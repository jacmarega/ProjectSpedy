using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Classificados.Models
{
    public class Conexao : DbContext
    {
        public Conexao() : base("ProjectSpedy")
        {

        }

        public DbSet<Classificados> Classificados { get; set; }
    }
}