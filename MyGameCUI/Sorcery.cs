using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameCUI
{
    class Sorcery : Card
    {
        // フィールド


        // コンストラクタ
        public Sorcery(string name, int cost, int faction):
            base(name, cost, faction)
        {
            CardType = Settings.Sorcery;
        }

        // プロパティ


        // メソッド

    }
}
