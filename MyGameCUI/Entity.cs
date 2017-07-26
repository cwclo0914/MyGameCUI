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


        /// <summary>
        /// CardList[n]をAからBに移動させる
        /// </summary>
        /// <param name="a">移動元のカードリスト</param>
        /// <param name="n">移動させるカードの番号</param>
        /// <param name="b">移動先のカードリスト</param>
        public void MoveCard(AbstractDeck a,int n,AbstractDeck b)
        {
            b.AddCard(a.CardList[0]);
            a.RemoveCard(0);
        }
        

        /// <summary>
        /// 山札から１枚カードを手札に加える
        /// </summary>
        public void Draw()
        {
            MoveCard(MyDeck,0,MyHand);
        }



        



    }
}
