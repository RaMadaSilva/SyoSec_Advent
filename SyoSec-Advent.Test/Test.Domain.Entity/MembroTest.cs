using SyoSec_Advent.Domain.Entities;
using SyoSec_Advent.Domain.ValueObject;
using System.Runtime.CompilerServices;

namespace SyoSec_Advent.Test.Test.Domain.Entity
{
    [TestClass]
    public class MembroTest
    {
        private readonly Member _member;
        private readonly Member _member2;
        private readonly Member _member3;
        private readonly Name _name;
        private readonly Address _address;
        public MembroTest() {
            _address = new Address("Zango 1", "Luanda", "Luanda"); 
            _name = new Name("Raul", "Silva");
            _member = new Member(_name, "923568923", _address);
            _member2 = new Member(_name, "923568923", _address);
            _member3 = new Member(_name, "912568923", _address);
        }
        [TestMethod]
        public void DadoDoisMembrosIguaisVerificarIgualdade()
        {
            Assert.IsTrue(_member.Equals(_member2));
        }

        [TestMethod]
        public void DadoDoisMembrosDiferenteVerificarIgualdade()
        {
            Assert.IsFalse(_member.Equals(_member3));
        }

    }
}
