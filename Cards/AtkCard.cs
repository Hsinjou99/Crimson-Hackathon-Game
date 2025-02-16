using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class AtkCard : Card
    {
        protected int durability;
        protected int max_durability;

        public AtkCard () {
            name = "attack";
            card_value = 3;
            color = Color.Red;
            max_durability = 4;
            durability = max_durability;
        }

        public int Atk_Val
        {
            get { return card_value; }
        }

        public int Durability
        {
            get { return durability; }
            set { durability = value; }
        }

        public int MaxDurability
        {
            get { return max_durability; }
        }

    }
}
