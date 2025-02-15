using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class AtkCard : Card
    {
        private int atk_val;
        private int durability;
        private Distance atk_type;

        public int Atk_Val
        {
            get { return atk_val; }
        }

        public int Durability
        {
            get { return durability; }
            set { durability = value; }
        }
    }
}
