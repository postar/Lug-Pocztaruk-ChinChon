using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogicLayer;
using System;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var deck = new GameDeck();
            deck.CreateDeck();
            Assert.AreEqual(50, deck.Cards.Count);
            Assert.AreEqual(1, deck.Cards[0].Number);
            Assert.AreEqual(Suit.Name.Copa, deck.Cards[0].Suit);
            Assert.AreEqual(1, deck.Cards[12].Number);
            Assert.AreEqual(Suit.Name.Espada, deck.Cards[12].Suit);
            Assert.AreEqual(1, deck.Cards[24].Number);
            Assert.AreEqual(Suit.Name.Oro, deck.Cards[24].Suit);
            Assert.AreEqual(1, deck.Cards[36].Number);
            Assert.AreEqual(Suit.Name.Basto, deck.Cards[36].Suit);
            Assert.AreEqual(0, deck.Cards[48].Number);
            Assert.AreEqual(Suit.Name.Comodin, deck.Cards[48].Suit);
            Assert.AreEqual(1, deck.Cards[49].Number);
            Assert.AreEqual(Suit.Name.Comodin, deck.Cards[49].Suit);
        }
    }
}
