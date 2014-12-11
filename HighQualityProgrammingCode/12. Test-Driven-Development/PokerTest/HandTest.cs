using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTest
{
    /// <summary>
    /// Summary description for HandTest
    /// </summary>
    [TestClass]
    public class HandTest
    {
        [TestMethod]
        public void TestHand()
        {
            Hand hand = new Hand(new List<ICard>{
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Spades)});

            string expected = "J♦Q♥4♠7♣A♠";
            string actual = hand.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
