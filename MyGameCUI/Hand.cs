using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 手札のカードリスト
/// </summary>
namespace MyGameCUI
{   
    class Hand : AbstractDeck
    {
        public Hand(List<Card> cardList): base(cardList)
        {
        }
        /// <summary>
        /// 使用可能な手札のリストを作る
        /// </summary>
        /// <returns></returns>
        public List<Card> PlayableCards()
        {
            List<Card> list = null;
            SelectSuitableCards(PlayableCondition);
            
            return list;
        }

        /// <summary>
        /// 手札のカードが使えるための条件
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public bool PlayableCondition(Card card)
        {            
            Entity ent = GameInfo.EntityAttacking;
            //マナが足りていないときはfalse
            if (ent.CurrentMana<card.Cost){ return false; }
            
            //モンスターの場合
            if(card.CardType == Settings.Monster)
            {
                //フィールドが埋まっていたら
                if(ent.MyBattleField.CountCard() == Settings.MaxCardOnField){ return false; }
                else { return true; }
            }else { return true; }
        }
        

    }
}
