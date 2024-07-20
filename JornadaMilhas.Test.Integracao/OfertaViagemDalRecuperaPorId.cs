using JornadaMilhas.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JornadaMilhas.Test.Integracao
{
    [CollectionDefinition(nameof(ContextoCollection))]
    public class OfertaViagemDalRecuperaPorId
    {
        private readonly JornadaMilhasContext context;

        public OfertaViagemDalRecuperaPorId(ContextoFixture contextoFixture)
        {
            context = contextoFixture.Context;
        }

        [Fact]
        public void RecuperaOfertaPorId()
        {
            //arrange
            var dal = new OfertaViagemDAL(context);

            //act
            var ofertaRecuperada = dal.RecuperarPorId(-2);

            //assert
            Assert.Null(ofertaRecuperada);
        }
    }
}
