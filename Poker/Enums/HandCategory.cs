using System.ComponentModel;

namespace Poker.Enums
{
    public enum HandCategory
    {
        [Description("Not Set")]
        NotSet,

        [Description("High Card")]
        HighCard,

        [Description("Pair")]
        Pair,

        [Description("Two Pair")]
        TwoPair,

        [Description("Three Of A Kind")]
        ThreeOfAKind,

        [Description("Straight")]
        Straight,

        [Description("Flush")]
        Flush,

        [Description("Full House")]
        FullHouse,

        [Description("Four Of A Kind")]
        FourOfAKind,

        [Description("Straight Flush")]
        StraightFlush,

        [Description("Royal Flush")]
        RoyalFlush
    }
}
