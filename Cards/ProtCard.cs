using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class ProtCard : Card
    {
        private int durability;

        public ProtCard () {
            name = "protect";
            color = Color.Blue;
            card_value = 10;
        }

        public int Durability {
            get { return durability; }
            set { durability = value; }
        }
    }
}
