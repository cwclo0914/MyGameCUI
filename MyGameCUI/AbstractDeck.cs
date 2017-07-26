using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// カードの束を管理するクラス
/// </summary>
namespace MyGameCUI
{
    abstract class AbstractDeck
    {

        /// <summary>
        /// カードの束
        /// </summary>
        public List<Card> CardList;

        /// <summary>
        /// カードの枚数を数える
        /// </summary>
        /// <returns>カードリストの枚数</returns>
        public int CountCard()
        {
            return CardList.Count();
        }

        /// <summary>
        /// カードを追加する
        /// </summary>      
        public void AddCard(Card card)
        {
            CardList.Add(card);

        }

        /// <summary>
        /// カードを１枚、リストから取り除く
        /// </summary>
        /// <param name="n">取り除くカードのリスト内の番号</param>
        /// <returns>取り除いたカード</returns>
        public Card RemoveCard(int n)
        {
            Card card = null;
            if (CountCard() > 0)
            {
                card = CardList[n];
                CardList.Remove(CardList[n]);
            }

            return card;
        }


        /// <summary>
        /// 条件に合うカードを探す
        /// </summary>
        /// <param name="lambla">条件</param>
        /// <returns>条件に合ったカードのリスト</returns>
        public List<Card> SelectSuitableCards(Func<Card, bool> lambda)
        {
            return CardList.Where(lambda).ToList();
        }

    }
}