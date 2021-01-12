using Poker.Enums;
using Poker.Utils;

namespace Poker.Entities
{
    public class Card
    {
        public CardSuit Suit { get; set; }
        public CardValue Value { get; set; }

        public override string ToString() => $"{EnumUtil.GetDescription(Value)}{EnumUtil.GetDescription(Suit)}";
    }
}
