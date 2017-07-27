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
        /// <summary>
        /// エフェクト1つのインスタントカード
        /// </summary>
        /// <param name="eff1">1つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        public Instant(string name, int cost, int faction, Effect eff1)
            : base(name, cost, faction, eff1)
        {
            CardType = Settings.Instant;
            StaysOnField = false;
        }

        /// <summary>
        /// エフェクト2つのインスタントカード
        /// </summary>
        /// <param name="eff1">1つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        /// <param name="eff2">2つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        public Instant(string name, int cost, int faction, Effect eff1, Effect eff2)
           : base(name, cost, faction, eff1, eff2)
        {
            CardType = Settings.Instant;
            StaysOnField = false;
        }

        /// <summary>
        /// エフェクト3つのインスタントカード
        /// </summary>
        /// <param name="eff1">1つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        /// <param name="eff2">2つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        /// <param name="eff3">3つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        public Instant(string name, int cost, int faction, Effect eff1, Effect eff2, Effect eff3)
         : base(name, cost, faction, eff1, eff2, eff3)
        {
            CardType = Settings.Instant;
            StaysOnField = false;
        }

        // プロパティ


        // メソッド

    }
}
