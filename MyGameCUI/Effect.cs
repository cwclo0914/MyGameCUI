using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameCUI
{
    abstract class Effect
    {
        // コンストラクタ
        public Effect()
        {
            Description = string.Empty;
        }

        // プロパティ
        public string Description { get; set; }
    }

    class EnchantThisHPStrEffect : Effect
    {
        // コンストラクタ
        public EnchantThisHPStrEffect()
        {
            Description += "";
        }

        // プロパティ

        // メソッド
        public void EnchantThisHPStr(Card card, int hpincre, int strincre)
        {
            card.HP += hpincre;
            card.Strength += strincre;
        }
    }
}
