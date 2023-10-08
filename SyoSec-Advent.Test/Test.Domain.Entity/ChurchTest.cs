using SyoSec_Advent.Domain.Entities;
using SyoSec_Advent.Domain.ValueObject;

namespace SyoSec_Advent.Test.Test.Domain.Entity
{
    [TestClass]
    public class ChurchTest
    {
        private readonly Address _adress; 
        private readonly Church _church;
        private readonly Church _churc2; 
        private readonly Church _churc3;
        
        public ChurchTest()
        {
            _adress = new Address("Mabor", "Cazenga-Luanda", "Luanda");
            _church = new Church("Mabor", _adress);
            _churc2 = new Church("Mabor", _adress);
            _churc3 = new Church("Cazenga", _adress); 
        }
        [TestMethod]
        public void DadaDuasIgrejasIguaisVerificarIgualdade()
        { 
            Assert.AreEqual(true, _church.Equals(_churc2));
        }

        [TestMethod]
        public void DadaDuasIgrejasDiferenteVerificarIgualdade()
        {
            Assert.AreEqual(false, _churc3.Equals(_churc2));
        }

    }
}
