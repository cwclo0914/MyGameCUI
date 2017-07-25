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
        ///  カードを探す
        /// </summary>
        /// <param name="card">目的のカード</param>
        /// <returns>目的のカードを出力：存在しない場合nullを返す</returns>
        public Card SearchCard(Card card)
        {
            Card card1 = new Card();

            //目的のカードが

            //モンスターの時
            //スペルの時
            //ソーサリーの時
            //インスタントの時
            //名前指定の時

            return card1;
        }


        /// <summary>
        /// 目的のカードが存在しているかを判定する
        /// </summary>
        /// <param name="card">目的のカード</param>
        /// <returns></returns>
        public bool ExistCard(Card card)
        {
            bool flag = false;


            return flag;
        }







    }
}
