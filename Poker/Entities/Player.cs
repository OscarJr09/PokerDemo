using System.Collections.Generic;

namespace Poker.Entities
{
    public class Player
    {
        public string Name { get; set; }
        public IList<Card> Cards { get; set; }
        public string HandCategory { get; set; }
    }
}
