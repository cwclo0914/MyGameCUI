using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameCUI
{
    /// <summary>
    /// エフェクトの抽象クラス
    /// </summary>
    abstract class Effect
    {
        // コンストラクタ
        public Effect()
        {
            Description = string.Empty;
        }

        // プロパティ
        /// <summary>
        /// カードに表示させる文言
        /// </summary>
        public string Description { get; set; }

        // メソッド
        /// <summary>
        /// エフェクト使用
        /// </summary>
        public abstract void ApplyEffect();
    }

    /// <summary>
    /// 一体の体力と攻撃力を上昇させる
    /// </summary>
    class EnchantOneHPStrEffect : Effect
    {
        // フィールド
        private int hpIncre; // 体力上昇値
        private int atkIncre; // 攻撃力上昇値

        // コンストラクタ
        /// <summary>
        /// 一体の体力と攻撃力を上昇させる
        /// </summary>
        /// <param name="hp">体力上昇値</param>
        /// <param name="atk">攻撃力上昇値</param>
        public EnchantOneHPStrEffect(int hp, int atk)
        {
            hpIncre = hp;
            atkIncre = atk;
            Description += "指定のモンスターを" + hpIncre.ToString("+#;-#;0") + "/" + atkIncre.ToString("+#;-#;0") + "する"; // +/-の符号を強制的に表示させる
        }

        // メソッド
        /// <summary>
        /// 味方のカードを指定させ、強化の効果を発揮する
        /// （！未完成）
        /// </summary>
        public override void ApplyEffect()
        {
            EnchantOneHPAtk();
        }

        /// <summary>
        /// 味方のカードを指定させ、強化の効果を発揮する
        /// （！未完成）
        /// </summary>
        private void EnchantOneHPAtk()
        {
            Card targetMonster = TargetAllyMonster(); // TargetAllyMonster()で、プレイヤーやAIに味方のカードを返してもらう
            targetMonster.HP += hpIncre;
            targetMonster.Attack += atkIncre;
        }
    }
}
