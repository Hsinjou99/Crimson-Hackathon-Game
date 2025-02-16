using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class RangedCard : AtkCard
    {
        public RangedCard(string cardName, int atk, int dur)
        {
            this.name = cardName;
            //this.attack_value = atk;
            this.max_durability = dur;
            this.durability = max_durability;
        }
    }
}
