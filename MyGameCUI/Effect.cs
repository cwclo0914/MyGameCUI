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
        public Effect(Entity owner)
        {
            Description = string.Empty;
            Owner = owner;
            if (owner == GameInfo.EntityAttacking)
                Opponent = GameInfo.EntityDefending;
            else
                Opponent = GameInfo.EntityAttacking;
        }

        // プロパティ
        /// <summary>
        /// カードに表示させる文言
        /// </summary>
        public string Description { get; set; }
        public Entity Owner { get; set; }
        public Entity Opponent { get; set; }

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
        private int hpIncre; // 体力上昇値
        private int atkIncre; // 攻撃力上昇値
        private int costThreshold;

        // コンストラクタ
        /// <summary>
        /// 自分のモンスター一体の体力と攻撃力を上昇させる
        /// </summary>
        /// <param name="hp">体力上昇値</param>
        /// <param name="atk">攻撃力上昇値</param>
        public EnchantSingleEffect(Entity owner, int hp, int atk)
            : base(owner)
        {
            hpIncre = hp;
            atkIncre = atk;
            Description += "召喚時、味方のモンスター一体を" + hpIncre.ToString("+#;-#;0") + "/" + atkIncre.ToString("+#;-#;0") + "する"; // +/-の符号を強制的に表示させる
        }

        // メソッド
        /// <summary>
        /// ターゲット決定
        /// </summary>
        public override void DetermineTarget()
        {
            List<Card> targetList = Owner.MyBattleField.SelectSuitableCards(x => true);
            target = SelectOne(targetList); // 味方のモンスター一体をreturn
        }

        /// <summary>
        /// 味方のモンスターを指定させ、強化の効果を発揮する
        /// </summary>
        public override void ApplyEffect()
        {
            target.HP += hpIncre;
            target.Attack += atkIncre;
        }
    }

    /// <summary>
    /// 召喚されたもの以外、自分のモンスター全体の体力と攻撃力を上昇させる（！コスト条件未完成）
    /// </summary>
    class EnchantAlliesEffect : Effect
    {
        // フィールド
        private List<Card> targetList;
        private int hpIncre; // 体力上昇値
        private int atkIncre; // 攻撃力上昇値

        // コンストラクタ
        /// <summary>
        /// 召喚されたもの以外、自分のモンスター全体の体力と攻撃力を上昇させる
        /// </summary>
        /// <param name="hp">体力上昇値</param>
        /// <param name="atk">攻撃力上昇値</param>
        public EnchantAlliesEffect(Entity owner, int hp, int atk)
            : base(owner)
        {
            hpIncre = hp;
            atkIncre = atk;
            Description += "召喚時、自分以外の味方のモンスター全てを" + hpIncre.ToString("+#;-#;0") + "/" + atkIncre.ToString("+#;-#;0") + "する"; // +/-の符号を強制的に表示させる
        }

        // メソッド
        /// <summary>
        /// ターゲット決定
        /// </summary>
        public override void DetermineTarget()
        {
            targetList = Owner.MyBattleField.SelectSuitableCards(x => true);
        }

        /// <summary>
        /// 味方のモンスター全てに強化の効果を発揮する
        /// </summary>
        public override void ApplyEffect()
        {
            foreach (Card monster in targetList)
            {
                monster.HP += hpIncre;
                monster.Attack += atkIncre;
            }
        }
    }

    class EnchantSelfOnMonsterEffect : Effect
    {
        // フィールド
        private Card target;
        private int hpIncre; // 体力上昇値
        private int atkIncre; // 攻撃力上昇値

        // コンストラクタ
        public EnchantSelfOnMonsterEffect(Entity owner, int hp, int atk)
            : base(owner)
        {
            hpIncre = hp;
            atkIncre = atk;
            Description += "モンスターに攻撃するとき、自分を" + hpIncre.ToString("+#;-#;0") + "/" + atkIncre.ToString("+#;-#;0") + "する"; // +/-の符号を強制的に表示させる
        }

        // メソッド
        public override void DetermineTarget()
        {
            List<Card> targetList = Owner.MyBattleField.SelectSuitableCards(x => true);
            target = 
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
        private int damage; // ダメージ

        // コンストラクタ
        /// <summary>
        /// 相手のモンスター一体にダメージを与える
        /// </summary>
        /// <param name="dam">ダメージ</param>
        public DamageSingleEffect(Entity owner, int dam)
            : base(owner)
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
            List<Card> targetList = Opponent.MyBattleField.SelectSuitableCards(x => true);
            target = SelectOne(targetList); // 味方のモンスター一体をreturn
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
        private int damage; // ダメージ

        // コンストラクタ
        /// <summary>
        /// 相手のモンスター全てにダメージを与える
        /// </summary>
        /// <param name="dam">ダメージ</param>
        public DamageEnemiesEffect(Entity owner, int dam)
            : base(owner)
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
            targetList = Owner.MyBattleField.SelectSuitableCards(x => true);
        }

        /// <summary>
        /// 相手のモンスターを指定させ、ダメージを与える
        /// </summary>
        public override void ApplyEffect()
        {
            foreach (Card monster in targetList)
            {
                monster.HP -= damage;
            }
        }
    }

    class 
}
