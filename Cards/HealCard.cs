using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class HealCard : Card
    {
        public HealCard () {
            name = "Heal";
            description = "Heals player by 5.";
            color = Color.Green;
            card_value = 5;
        }

        public int Value
        {
            get { return card_value; }
        }
    }
}
