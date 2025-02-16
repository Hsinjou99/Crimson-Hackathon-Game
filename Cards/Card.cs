using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Card
    {
        protected string name;
        protected int card_value;
        protected Color color;

        public Color CardColor
        {
            get { return color; }
        }

        public int CardValue
        {
            get { return card_value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
