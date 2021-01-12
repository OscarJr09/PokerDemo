using NUnit.Framework;
using Poker;
using Poker.Entities;
using PokerTest.TestData;
using System.Collections.Generic;
using System.Linq;

namespace PokerTest
{
    [TestFixture]
    public class PokerAnalyzerTest
    {
        [Test]
        [TestCase("flush","joe")]
        [TestCase("pair", "jen")]
        [TestCase("royal flush", "bill")]
        [TestCase("straight flush", "mark")]
        [TestCase("full house", "ana")]
        public void GetWinner(string category, string expectedResult)
        {
            var players = new List<Player>();
            switch (category)
            {
                case "flush":
                    players = PokerPlayers.Flush;
                    break;
                case "pair":
                    players = PokerPlayers.Pair;
                    break;
                case "royal flush":
                    players = PokerPlayers.RoyalFlush;
                    break;
                case "straight flush":
                    players = PokerPlayers.StraightFlush;
                    break;
                case "full house":
                    players = PokerPlayers.FullHouse;
                    break;
            }                

            var playPoker = new PokerAnalyzer();
            var winner = playPoker.GetWinner(players);

            Assert.That(winner.Any(w => w.Name.ToLower().Equals(expectedResult)));
        }

        [Test]
        public void GetWinners()
        {
            var players = PokerPlayers.RoyalFlushTie;

            var playPoker = new PokerAnalyzer();
            var winners = playPoker.GetWinner(players);

            CollectionAssert.AreEquivalent(new[] { "bob", "bill" }, winners.Select(p => p.Name.ToLower()).ToList());
        }
    }
}
