using SyoSec_Advent.Domain.Entities;
using SyoSec_Advent.Domain.Enums;
using SyoSec_Advent.Domain.ValueObject;

namespace SyoSec_Advent.Test.Test.Domain.Entity
{
    [TestClass]
    public class RecommendationTest
    {
        [TestMethod]
        public void DadaUmaRecomendacaoDentroDoPrazoActualizarOEstadoParaInvalido()
        {
            var adress = new Address("cazenga", "Luanda", "Luanda");
            var adressChurch = new Address("Viana", "Zango", "Luanda"); 
            var name = new Name("Raul", "Silva"); 
            var member = new Member(name, "923568923",adress );
            var church = new Church("Mabor", adressChurch); 
            var recomendacao = new Recommendation(member,church, "O referido está sozinho", ERecommendationType.Recebida);
            var result = recomendacao.UpdateStateRecommendationToInvalide(); 
            Assert.AreEqual(false, result); 
        }

        [TestMethod]
        public void DadaUmaRecomendacaoForaDoPrazoActualizarOEstadoParaDevololvido()
        {
            Assert.Fail(); 
        }
        public void DadaUmaRecomendacaoActualizarOEstadoParaDevololvido()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void DadaUmaRecomendacaoActualizarOEstadoParaTransferencia()
        {
            Assert.Fail(); 
        }
        
    }
}
