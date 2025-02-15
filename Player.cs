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
        private List<Card> playable;
        private List<Card> played;

        public Player()
        {
            this.hp = 10;

            for (int indexer = 0; indexer < 4; indexer++) {
                CardTypes randCard = RandomEnumValue<CardTypes>();
                if (randCard == CardTypes.Atk)
                {
                    this.playable.Add(new AtkCard());
                }
                else if (randCard == CardTypes.Sup)
                {
                    this.playable.Add(new SupCard());
                }
                else if (randCard == CardTypes.Def)
                {
                    this.playable.Add(new ProtCard());
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
