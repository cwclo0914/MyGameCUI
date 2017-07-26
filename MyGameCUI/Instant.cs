using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameCUI
{
    class Instant : Card
    {
        // フィールド


        // コンストラクタ
        public Instant(string name, int cost, int faction):
            base(name, cost, faction)
        {
            CardType = Settings.Instant;
        }

        // プロパティ


        // メソッド

    }
}
