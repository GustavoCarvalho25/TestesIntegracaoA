using JornadaMilhas.Dados;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JornadaMilhas.Test.Integracao
{
    //Possibilidades: ClassFixture, CollectionFixture e AssemblyFixture
    public class ContextoFixture
    {
        public JornadaMilhasContext Context { get; }

        public ContextoFixture()
        {
            var options = new DbContextOptionsBuilder<JornadaMilhasContext>()
            .UseSqlServer("Server=localhost;Database=JornadaMilhas;User Id=sa;Password=Nesher!2020;Trusted_Connection=True;")
            .Options;
            Context = new JornadaMilhasContext(options);
        }

        
    }
}
