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
        /// <summary>
        /// エフェクト1つのソーサリーカード
        /// </summary>
        /// <param name="eff1">1つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        public Sorcery(string name, int cost, int faction, Effect eff1)
            : base(name, cost, faction, eff1)
        {
            CardType = Settings.Sorcery;
            StaysOnField = false;
        }

        /// <summary>
        /// エフェクト2つのソーサリーカード
        /// </summary>
        /// <param name="eff1">1つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        /// <param name="eff2">2つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        public Sorcery(string name, int cost, int faction, Effect eff1, Effect eff2)
           : base(name, cost, faction, eff1, eff2)
        {
            CardType = Settings.Sorcery;
            StaysOnField = false;
        }

        /// <summary>
        /// エフェクト3つのソーサリーカード
        /// </summary>
        /// <param name="eff1">1つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        /// <param name="eff2">2つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        /// <param name="eff3">3つめのエフェクト（インスタンス"new xxxEffect()"で入力してください）</param>
        public Sorcery(string name, int cost, int faction, Effect eff1, Effect eff2, Effect eff3)
         : base(name, cost, faction, eff1, eff2, eff3)
        {
            CardType = Settings.Sorcery;
            StaysOnField = false;
        }

        // プロパティ


        // メソッド

    }
}
