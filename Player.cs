using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Player
    {
        private enum CardTypes {
            Atk,
            Sup,
            Def
        }

        static Random R = new Random();
        static T RandomEnumValue<T>()
        {
            var v = Enum.GetValues(typeof(T));
            return (T)v.GetValue(R.Next(v.Length));
        }

        private int hp;
        public List<Card> playable;
        private List<Card> played;

        public Player()
        {
            this.hp = 10;

            playable = new List<Card>();
            played = new List<Card>();

            for (int indexer = 0; indexer < 4; indexer++) {
                CardTypes randCard = RandomEnumValue<CardTypes>();
                if (randCard == CardTypes.Atk)
                {
                    AtkCard atk = new AtkCard();
                    this.playable.Add(atk);
                }
                else if (randCard == CardTypes.Sup)
                {
                    SupCard sup = new SupCard();
                    this.playable.Add(sup);
                }
                else if (randCard == CardTypes.Def)
                {
                    ProtCard prot = new ProtCard();
                    this.playable.Add(prot);
                }
            }
        }

        public void play_card (int card) {
            Card curr = playable[card];
            played.Add(curr);
            playable.RemoveAt(card);
        }
    }
}
