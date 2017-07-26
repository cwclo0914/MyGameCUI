using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameCUI
{
    class Monster : Card
    {
        // フィールド


        // コンストラクタ
        public Monster(string name, int cost, int faction, int hp, int str)
            : base(name, cost, faction)
        {
            HP = hp;
            Strength = str;
            CardType = Settings.Monster;
        }

        // プロパティ


        // メソッド

    }
}
