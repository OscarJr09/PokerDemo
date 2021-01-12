using Poker.Entities;
using Poker.Enums;
using Poker.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    public class PokerAnalyzer
    {
        private const int Pair = 2;
        private const int ThreeOfAKind = 3;
        private const int FourOfAKind = 4;

        public List<Player> GetWinner(List<Player> players)
        {
            try
            {
                var pokerWinner = new List<Player>();
                var playerHands = new List<PlayerHand>();

                players.ForEach(p => playerHands.Add(determinePlayerHand(p)));

                var winner = playerHands
                    .OrderByDescending(p => p.Strength)
                    .First();

                var tiedPlayers = playerHands.Where(p => p.Player.HandCategory == winner.Player.HandCategory).ToList();

                if (tiedPlayers.Count() > 1)
                {
                    return tiedPlayers.Select(p => p.Player).ToList();
                }

                return new List<Player> { winner.Player };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private PlayerHand determinePlayerHand(Player player)
        {
            var playerHand = new PlayerHand
            {
                Player = player
            };

            var cards = player.Cards;
            var cardValuelist = cards.Select(c => (int)c.Value).ToList();
            var frequencies = cards.GroupBy(c => c.Value).Select(g => g.Count()).OrderByDescending(c => c).ToArray();
            (int frq1, int frq2) = (frequencies[0], frequencies.Length > 1 ? frequencies[1] : 0);

            var category = HandCategory.NotSet;
            var firstAddition = 0;
            var secondAddition = 0;
            var thirdAddition = 0;
            var fourthAddition = 0;
            var fifthAddition = 0;

            var description = string.Empty;

            var highCard = cardValuelist.Max();
            var lowCard = cardValuelist.Min();
            var isStraight = cardValuelist.Max() - cardValuelist.Min() == 4;
            var isFlush = cards.All(c => c.Suit == cards.First().Suit);
            var isRoyalFlush = isFlush && (CardValue)highCard == CardValue.Ace && (CardValue)lowCard == CardValue.Ten;
            var groups = cardValuelist.GroupBy(x => x).ToList();

            switch (isRoyalFlush, isFlush, isStraight, frq1, frq2)
            {
                case (true, true, true, _, _):
                    category = HandCategory.RoyalFlush;
                    firstAddition = highCard;
                    description = EnumUtil.GetDescription(HandCategory.RoyalFlush);
                    break;
                case (_, true, true, _, _):
                    category = HandCategory.StraightFlush;
                    firstAddition = highCard;
                    description = EnumUtil.GetDescription(HandCategory.StraightFlush);
                    break;
                case (_, true, _, _, _):
                    category = HandCategory.Flush;
                    firstAddition = highCard;
                    description = EnumUtil.GetDescription(HandCategory.Flush);
                    break;
                case (_, _, true, _, _):
                    category = HandCategory.Straight;
                    firstAddition = highCard;
                    description = EnumUtil.GetDescription(HandCategory.Straight);
                    break;
                case (_, _, _, ThreeOfAKind, Pair):
                    category = HandCategory.FullHouse;
                    firstAddition = getThreeOfAKind(groups).Key;
                    secondAddition = getPairs(groups).First().Key;
                    description = EnumUtil.GetDescription(HandCategory.FullHouse);
                    break;
                case (_, _, _, Pair, Pair):
                    category = HandCategory.TwoPair;
                    var pairs = getPairs(groups);
                    firstAddition = pairs.Select(p => p.Key).Max();
                    secondAddition = pairs.Select(p => p.Key).Min();
                    thirdAddition = groups.First(g => g.Count() == 1).Key;
                    description = EnumUtil.GetDescription(HandCategory.TwoPair);
                    break;
                case (_, _, _, ThreeOfAKind, _):
                    category = HandCategory.ThreeOfAKind;
                    var threeOfAKind = getThreeOfAKind(groups);
                    firstAddition = threeOfAKind.Key;
                    secondAddition = cardValuelist.Where(x => x != threeOfAKind.Key).Max();
                    thirdAddition = cardValuelist.Where(x => x != threeOfAKind.Key).Min();
                    description = EnumUtil.GetDescription(HandCategory.ThreeOfAKind);
                    break;
                case (_, _, _, Pair, _):
                    category = HandCategory.Pair;
                    firstAddition = getPairs(groups).First().Key;
                    var otherCards = groups.Where(g => g.Count() == 1).Select(g => g.Key).OrderBy(x => x).ToList();
                    secondAddition = otherCards[0];
                    thirdAddition = otherCards[1];
                    fourthAddition = otherCards[2];
                    description = EnumUtil.GetDescription(HandCategory.Pair);
                    break;
                case (_, _, _, FourOfAKind, _):
                    category = HandCategory.FourOfAKind;
                    var fourOfAKind = groups.FirstOrDefault(g => g.Count() == FourOfAKind);
                    firstAddition = fourOfAKind.Key;
                    secondAddition = cardValuelist.Where(x => x != fourOfAKind.Key).Max();
                    description = EnumUtil.GetDescription(HandCategory.FourOfAKind);
                    break;
                default:
                    category = HandCategory.HighCard;
                    var orderedCards = cardValuelist.OrderByDescending(x => x).ToList();
                    firstAddition = orderedCards[0];
                    secondAddition = orderedCards[1];
                    thirdAddition = orderedCards[2];
                    fourthAddition = orderedCards[3];
                    fifthAddition = orderedCards[4];
                    description = EnumUtil.GetDescription(HandCategory.HighCard);
                    break;
            };

            var score = ((int)category * 10000000000) +
                        (firstAddition * 100000000) +
                        (secondAddition * 1000000) +
                        (thirdAddition * 10000) +
                        (fourthAddition * 100) +
                        fifthAddition;

            playerHand.Player.HandCategory = description;
            playerHand.Strength = score;

            return playerHand;
        }

        private IGrouping<int, int> getThreeOfAKind(List<IGrouping<int, int>> groups)
        {
            return groups.FirstOrDefault(g => g.Count() == ThreeOfAKind);
        }

        private List<IGrouping<int, int>> getPairs(List<IGrouping<int, int>> groups)
        {
            return groups.Where(g => g.Count() == Pair).ToList();
        }
    }
}
