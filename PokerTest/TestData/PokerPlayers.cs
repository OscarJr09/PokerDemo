using Poker.Entities;
using Poker.Enums;
using System.Collections.Generic;

namespace PokerTest.TestData
{
    public static class PokerPlayers
    {
        public static List<Player> Flush = new List<Player> {
            new Player {
                Name = "Joe",
                Cards = new List<Card> {
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Three},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Six},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Eight},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Jack},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.King},
                }
            },
            new Player {
                Name = "Jen",
                Cards = new List<Card> {
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Three},
                    new Card { Suit = CardSuit.Diamonds, Value = CardValue.Three},
                    new Card { Suit = CardSuit.Spades, Value = CardValue.Three},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Eight},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Ten},
                }
            },
            new Player {
                Name = "Bob",
                Cards = new List<Card> {
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Deuce},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Five},
                    new Card { Suit = CardSuit.Spades, Value = CardValue.Seven},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Ten},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Ace},
                }
            }
        };

        public static List<Player> Pair = new List<Player> {
            new Player {
                Name = "Joe",
                Cards = new List<Card> {
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Three},
                    new Card { Suit = CardSuit.Diamonds, Value = CardValue.Four},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Nine},
                    new Card { Suit = CardSuit.Diamonds, Value = CardValue.Nine},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Queen},
                }
            },
            new Player {
                Name = "Jen",
                Cards = new List<Card> {
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Five},
                    new Card { Suit = CardSuit.Diamonds, Value = CardValue.Seven},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Nine},
                    new Card { Suit = CardSuit.Spades, Value = CardValue.Nine},
                    new Card { Suit = CardSuit.Spades, Value = CardValue.Queen},
                }
            },
            new Player {
                Name = "Bob",
                Cards = new List<Card> {
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Deuce},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Deuce},
                    new Card { Suit = CardSuit.Spades, Value = CardValue.Five},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Ten},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Ace},
                }
            }
        };

        public static List<Player> RoyalFlush = new List<Player> {
            new Player {
                Name = "Joe",
                Cards = new List<Card> {
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Three},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Six},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Eight},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Jack},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.King},
                }
            },
            new Player {
                Name = "Jen",
                Cards = new List<Card> {
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Three},
                    new Card { Suit = CardSuit.Diamonds, Value = CardValue.Three},
                    new Card { Suit = CardSuit.Spades, Value = CardValue.Eight},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Eight},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Ten},
                }
            },
            new Player {
                Name = "Bob",
                Cards = new List<Card> {
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Nine},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Nine},
                    new Card { Suit = CardSuit.Spades, Value = CardValue.Nine},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Seven},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Seven},
                }
            },
            new Player {
                Name = "Bill",
                Cards = new List<Card> {
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Ace},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Ten},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Queen},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Jack},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.King},
                }
            }
        };

        public static List<Player> RoyalFlushTie = new List<Player> {
            new Player {
                Name = "Joe",
                Cards = new List<Card> {
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Three},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Six},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Eight},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Jack},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.King},
                }
            },
            new Player {
                Name = "Jen",
                Cards = new List<Card> {
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Three},
                    new Card { Suit = CardSuit.Diamonds, Value = CardValue.Three},
                    new Card { Suit = CardSuit.Spades, Value = CardValue.Eight},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Eight},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Ten},
                }
            },
            new Player {
                Name = "Bob",
                Cards = new List<Card> {
                    new Card { Suit = CardSuit.Diamonds, Value = CardValue.Ace},
                    new Card { Suit = CardSuit.Diamonds, Value = CardValue.Ten},
                    new Card { Suit = CardSuit.Diamonds, Value = CardValue.Queen},
                    new Card { Suit = CardSuit.Diamonds, Value = CardValue.Jack},
                    new Card { Suit = CardSuit.Diamonds, Value = CardValue.King},
                }
            },
            new Player {
                Name = "Bill",
                Cards = new List<Card> {
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Ace},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Ten},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Queen},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Jack},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.King},
                }
            }
        };

        public static List<Player> Tie = new List<Player> {
            new Player {
                Name = "Joe",
                Cards = new List<Card> {
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Three},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Six},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Eight},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Jack},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.King},
                }
            },
            new Player {
                Name = "Pil",
                Cards = new List<Card> {
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Three},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Six},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Eight},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Jack},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.King},
                }
            },
            new Player {
                Name = "Jen",
                Cards = new List<Card> {
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Three},
                    new Card { Suit = CardSuit.Diamonds, Value = CardValue.Three},
                    new Card { Suit = CardSuit.Spades, Value = CardValue.Three},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Eight},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Ten},
                }
            },
            new Player {
                Name = "Bob",
                Cards = new List<Card> {
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Deuce},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Five},
                    new Card { Suit = CardSuit.Spades, Value = CardValue.Seven},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Ten},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Ace},
                }
            }
        };

        public static List<Player> StraightFlush = new List<Player> {
            new Player {
                Name = "Joe",
                Cards = new List<Card> {
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Three},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Six},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Eight},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Jack},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.King},
                }
            },
            new Player {
                Name = "Jen",
                Cards = new List<Card> {
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Three},
                    new Card { Suit = CardSuit.Diamonds, Value = CardValue.Three},
                    new Card { Suit = CardSuit.Spades, Value = CardValue.Eight},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Eight},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Ten},
                }
            },
            new Player {
                Name = "Bob",
                Cards = new List<Card> {
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Nine},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Nine},
                    new Card { Suit = CardSuit.Spades, Value = CardValue.Nine},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Seven},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Seven},
                }
            },
            new Player {
                Name = "Mark",
                Cards = new List<Card> {
                    new Card { Suit = CardSuit.Diamonds, Value = CardValue.Four},
                    new Card { Suit = CardSuit.Diamonds, Value = CardValue.Five},
                    new Card { Suit = CardSuit.Diamonds, Value = CardValue.Six},
                    new Card { Suit = CardSuit.Diamonds, Value = CardValue.Seven},
                    new Card { Suit = CardSuit.Diamonds, Value = CardValue.Eight},
                }
            }
        };

        public static List<Player> FullHouse = new List<Player> {
            new Player {
                Name = "Ana",
                Cards = new List<Card> {
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Nine},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Nine},
                    new Card { Suit = CardSuit.Spades, Value = CardValue.Nine},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Seven},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Seven},
                }
            },
            new Player {
                Name = "Henry",
                Cards = new List<Card> {
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Six},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Seven},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Eight},
                    new Card { Suit = CardSuit.Spades, Value = CardValue.Nine},
                    new Card { Suit = CardSuit.Spades, Value = CardValue.Ten},
                }
            },
            new Player {
                Name = "Pil",
                Cards = new List<Card> {
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Three},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Six},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Eight},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Jack},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.King},
                }
            },
            new Player {
                Name = "Jen",
                Cards = new List<Card> {
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Three},
                    new Card { Suit = CardSuit.Diamonds, Value = CardValue.Three},
                    new Card { Suit = CardSuit.Spades, Value = CardValue.Three},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Eight},
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Ten},
                }
            },
            new Player {
                Name = "Bob",
                Cards = new List<Card> {
                    new Card { Suit = CardSuit.Hearts, Value = CardValue.Deuce},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Five},
                    new Card { Suit = CardSuit.Spades, Value = CardValue.Seven},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Ten},
                    new Card { Suit = CardSuit.Clubs, Value = CardValue.Ace},
                }
            }
        };
    }
}
