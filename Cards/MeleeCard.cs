using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class MeleeCard : AtkCard
    {
        public MeleeCard(string cardName, int atk, int dur) {
            this.name = cardName;
            this.attack_value = atk;
            this.durability = dur;
            this.max_durability = dur;
        }
    }
}
