using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Player
    {
        private enum CardTypes {
            Atk,
            Heal,
            Def
        }

        static Random R = new Random();
        static T RandomEnumValue<T>()
        {
            var v = Enum.GetValues(typeof(T));
            return (T)v.GetValue(R.Next(v.Length));
        }

        public int hp;
        public bool protection = false;
        public List<Card> playable;
        public List<Card> played;

        public Player()
        {
            this.hp = 10;

            this.playable = new List<Card>();
            this.played = new List<Card>();

            for (int indexer = 0; indexer < 4; indexer++) {
                CardTypes randCard = RandomEnumValue<CardTypes>();
                if (randCard == CardTypes.Atk)
                {
                    AtkCard atk = new AtkCard();
                    this.playable.Add(atk);
                }
                else if (randCard == CardTypes.Heal)
                {
                    HealCard heal = new HealCard();
                    this.playable.Add(heal);
                }
                else if (randCard == CardTypes.Def)
                {
                    ProtCard prot = new ProtCard();
                    this.playable.Add(prot);
                }
            }
        }

        public void play_card(int card)
        {
            Card curr = playable[card];
            playable.RemoveAt(card);

            if (curr.Name == "Attack")
            {
                if (played.Count < 3) { 
                    played.Add(curr);
                }
            }
            else if (curr.Name == "Protect")
            {
                protection = true;
            }
            else if (curr.Name == "Heal")
            {
                hp += curr.CardValue;
                if (hp > 10)
                {
                    hp = 10;
                }
            }
        }

        public void draw_card()
        {
            int draw = 0;
            while (playable.Count < 5 && draw < 2)
            {
                draw++;

                CardTypes randCard = RandomEnumValue<CardTypes>();
                if (randCard == CardTypes.Atk)
                {
                    AtkCard atk = new AtkCard();
                    this.playable.Add(atk);
                }
                else if (randCard == CardTypes.Heal)
                {
                    HealCard heal = new HealCard();
                    this.playable.Add(heal);
                }
                else if (randCard == CardTypes.Def)
                {
                    ProtCard prot = new ProtCard();
                    this.playable.Add(prot);
                }
            }
        }
    }
}
