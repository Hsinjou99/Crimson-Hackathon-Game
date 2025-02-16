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
            name = "Protect";
            description = "Blocks all damage for one turn.";
            color = Color.Blue;
        }

        public int Durability {
            get { return durability; }
            set { durability = value; }
        }
    }
}
