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
        }

        // プロパティ
        public override int HP { get; set; }
        public override int Strength { get; set; }

        // メソッド
        public override void AddEffect()
        {
            throw new NotImplementedException();
        }
    }
}
