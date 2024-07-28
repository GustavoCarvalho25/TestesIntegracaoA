using JornadaMilhas.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace JornadaMilhas.Test.Integracao
{
    [Collection(nameof(ContextoCollection))]
    public class OfertaViagemDalRecuperarTodas
    {
        private readonly JornadaMilhasContext context;
        private readonly ITestOutputHelper output;

        public OfertaViagemDalRecuperarTodas(ITestOutputHelper output, ContextoFixture fixture)
        {
            this.context = fixture.Context;
            this.output = output;
            output.WriteLine(context.GetHashCode().ToString());
        }

        [Fact]
        public void DeveRecuperarTodasAsOfertasDeViagem()
        {
            // Arrange
            var dal = new OfertaViagemDAL(context);

            // Act
            var ofertas = dal.RecuperarTodas();

            // Assert
            Assert.NotNull(ofertas);
            Assert.NotEmpty(ofertas);
            output.WriteLine($"Número de ofertas recuperadas: {ofertas.Count()}");
        }

    }
}
