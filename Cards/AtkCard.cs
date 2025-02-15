using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class AtkCard : Card
    {
        protected int attack_value;
        protected int durability;
        protected int max_durability;

        public int Atk_Val
        {
            get { return attack_value; }
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
