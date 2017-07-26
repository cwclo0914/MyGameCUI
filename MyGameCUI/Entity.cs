using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameCUI
{
    class Entity
    {
        public Entity()
        {
            Life = Settings.InitLife;
            MaxMana = 0;
            CurrentMana = 0;
        }

        public int Life { get; set; }
        public int MaxMana { get; set; }
        public int CurrentMana { get; set; }
        public Deck MyDeck { get; set; }
        public Hand MyHand { get; set; }
        public Grave MyGrave { get; set; }
        public BattleField MyBattleField { get; set; }
    }
}
