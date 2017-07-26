using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameCUI
{
    class Entity
    {
        Entity()
        {
            Life = Settings.InitLife;
            MaxMana = 0;
            CurrenMana = 0;
        }


        public int Life { get; set; }
        public int MaxMana { get; set; }
        public int CurrenMana { get; set; }
        public Deck MyDeck;
        public Hand MyHand;
        public Grave MyGrave;
        public BattleField MyBattleField;
        

        


    }
}
