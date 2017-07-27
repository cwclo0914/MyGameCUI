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
        public Effect(Card cardOfThisEffect)
        {
            Description = string.Empty;
            CardOfThisEffect = cardOfThisEffect;
        }

        // プロパティ
        /// <summary>
        /// カードに表示させる文言
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// このエフェクトのインスタンスを保有するカード
        /// </summary>
        public Card CardOfThisEffect { get; set; }

        // メソッド
        /// <summary>
        /// ターゲット決定
        /// </summary>
        public abstract void DetermineTarget();

        /// <summary>
        /// エフェクト使用
        /// </summary>
        /// <param name="entity">エフェクトの対象</param>
        public abstract void ApplyEffect();
    }

    /// <summary>
    /// 味方のモンスター一体の体力と攻撃力を上昇させる（！1枚選択未完成）
    /// </summary>
    class EnchantSingleEffect : Effect
    {
        // フィールド
        private Card target;
        private int hpIncrement;
        private int atkIncrement;
        private int costThreshold;

        // コンストラクタ
        /// <summary>
        /// 自分のモンスター一体の体力と攻撃力を上昇させる
        /// </summary>
        /// <param name="cardOfThisEffect">このエフェクトを保有するカード</param>
        /// <param name="hp">体力上昇値</param>
        /// <param name="atk">攻撃力上昇値</param>
        public EnchantSingleEffect(Card cardOfThisEffect, int hp, int atk)
            : base(cardOfThisEffect)
        {
            hpIncrement = hp;
            atkIncrement = atk;
            Description += "召喚時、味方のモンスター一体を" + hpIncrement.ToString("+#;-#;0") + "/" + atkIncrement.ToString("+#;-#;0") + "する"; // +/-の符号を強制的に表示させる
        }

        // メソッド
        /// <summary>
        /// ターゲット決定
        /// </summary>
        public override void DetermineTarget()
        {
            List<Card> targetList = CardOfThisEffect.Owner.MyBattleField.SelectSuitableCards(x => true);
            target = SelectOne(targetList); // 味方のモンスター一体をreturn
        }

        private Card SelectOne(List<Card> targetList) // バトルフィールドで書くべき？
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 味方のモンスターを指定させ、強化の効果を発揮する
        /// </summary>
        public override void ApplyEffect()
        {
            target.HP += hpIncrement;
            target.Attack += atkIncrement;
        }
    }

    /// <summary>
    /// 召喚されたもの以外、自分のモンスター全体の体力と攻撃力を上昇させる（！コスト条件未完成）
    /// </summary>
    class EnchantAlliesEffect : Effect
    {
        // フィールド
        private List<Card> targetList;
        private int hpIncrement;
        private int atkIncrement;

        // コンストラクタ
        /// <summary>
        /// 召喚されたもの以外、自分のモンスター全体の体力と攻撃力を上昇させる
        /// </summary>
        /// <param name="cardOfThisEffect">このエフェクトを保有するカード</param>
        /// <param name="hp">体力上昇値</param>
        /// <param name="atk">攻撃力上昇値</param>
        public EnchantAlliesEffect(Card cardOfThisEffect, int hp, int atk)
            : base(cardOfThisEffect)
        {
            hpIncrement = hp;
            atkIncrement = atk;
            Description += "召喚時、自分以外の味方のモンスター全てを" + hpIncrement.ToString("+#;-#;0") + "/" + atkIncrement.ToString("+#;-#;0") + "する"; // +/-の符号を強制的に表示させる
        }

        // メソッド
        /// <summary>
        /// ターゲット決定
        /// </summary>
        public override void DetermineTarget()
        {
            targetList = CardOfThisEffect.Owner.MyBattleField.SelectSuitableCards(x => true);
        }

        /// <summary>
        /// 味方のモンスター全てに強化の効果を発揮する
        /// </summary>
        public override void ApplyEffect()
        {
            foreach (Card monster in targetList)
            {
                monster.HP += hpIncrement;
                monster.Attack += atkIncrement;
            }
        }
    }

    class EnchantSelfOnMonsterEffect : Effect
    {
        // フィールド
        private Card target;
        private int hpIncrement;
        private int atkIncrement;

        // コンストラクタ
        public EnchantSelfOnMonsterEffect(Card cardOfThisEffect, int hp, int atk)
            : base(cardOfThisEffect)
        {
            hpIncrement = hp;
            atkIncrement = atk;
            Description += "モンスターに攻撃するとき、自分を" + hpIncrement.ToString("+#;-#;0") + "/" + atkIncrement.ToString("+#;-#;0") + "する"; // +/-の符号を強制的に表示させる
        }

        // メソッド
        public override void DetermineTarget()
        {
            target = CardOfThisEffect;
        }

        public override void ApplyEffect()
        {
            
        }
    }

    /// <summary>
    /// 相手のモンスター一体にダメージを与える（！1枚選択未完成）
    /// </summary>
    class DamageSingleEffect : Effect
    {
        // フィールド
        private Card target;
        private int damage;

        // コンストラクタ
        /// <summary>
        /// 相手のモンスター一体にダメージを与える
        /// </summary>
        /// <param name="cardOfThisEffect">このエフェクトを保有するカード</param>
        /// <param name="dam">ダメージ</param>
        public DamageSingleEffect(Card cardOfThisEffect, int dam)
            : base(cardOfThisEffect)
        {
            damage = dam;
            Description += "召喚時、相手のモンスター一体に" + damage.ToString() + "ダメージ"; // ToStringを一致させるべき？
        }

        // メソッド
        /// <summary>
        /// ターゲット決定
        /// </summary>
        public override void DetermineTarget()
        {
            List<Card> targetList = CardOfThisEffect.Opponent.MyBattleField.SelectSuitableCards(x => true);
            target = SelectOne(targetList); // 味方のモンスター一体をreturn
        }

        private Card SelectOne(List<Card> targetList)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 相手のモンスターを指定させ、ダメージを与える
        /// </summary>
        public override void ApplyEffect()
        {
            target.HP -= damage;
        }
    }

    /// <summary>
    /// 相手のモンスター全てにダメージを与える（！コスト条件未完成）
    /// </summary>
    class DamageEnemiesEffect : Effect
    {
        // フィールド
        private List<Card> targetList;
        private int damage;

        // コンストラクタ
        /// <summary>
        /// 相手のモンスター全てにダメージを与える
        /// </summary>
        /// <param name="cardOfThisEffect">このエフェクトを保有するカード</param>
        /// <param name="dam">ダメージ</param>
        public DamageEnemiesEffect(Card cardOfThisEffect, int dam)
            : base(cardOfThisEffect)
        {
            damage = dam;
            Description += "召喚時、相手のモンスター全てに" + damage.ToString() + "ダメージ"; // ToStringを一致させるべき？
        }

        // メソッド
        /// <summary>
        /// ターゲット決定
        /// </summary>
        public override void DetermineTarget()
        {
            targetList = CardOfThisEffect.Opponent.MyBattleField.SelectSuitableCards(x => true);
        }

        /// <summary>
        /// 対象となった相手のモンスターにダメージを与える
        /// </summary>
        public override void ApplyEffect()
        {
            foreach (Card monster in targetList)
            {
                monster.HP -= damage;
            }
        }
    }
}
