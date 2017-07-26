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
        ///カードを一枚、リストに追加する
        /// </summary>
        /// <param name="card">追加するカード</param>
        public void AddCard(Card card){
            CardList.Add(card);
        }

        /// <summary>
        /// カードを１枚、リストから取り除く
        /// </summary>
        /// <param name="n">取り除くカードのリスト内の番号</param>
        public void RemoveCard(int n)
        {
            CardList.Remove(CardList[n]);
        }

        /// <summary>
        /// リストに入っているカードを１枚探す
        /// </summary>
        /// <param name="card">目的のカード</param>
        /// <param name="searchType">検索方法：0名前 1種類</param>
        /// <returns>リスト内の番号*存在しないとき-1</returns>
        public int SearchCard(Card card,int searchType)
        {
            int cardNum = -1;

            switch (searchType)
            {
                case 0:
                    //名前指定の時
                    cardNum = NameSearchCard(card);
                    break;
                    
                case 1:
                    //種類検索のとき
                    cardNum = TypeSearchCard(card);
                    break;

            }

            return cardNum;
        }

        /// <summary>
        /// 名前指定されたときにカードを探す方法
        /// </summary>
        public int NameSearchCard(Card card)
        {
            for(int i= 0; i < CountCard(); i++)
            {
                if(CardList[i].Name == card.Name)
                {
                    return i;
                }
            }
            return -1;

        }

        /// <summary>
        /// 種類指定されたときにカードを探す方法
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public int TypeSearchCard(Card card)
        {
            for (int i = 0; i < CountCard(); i++)
            {
                if (CardList[i].CardType == card.CardType)
                {
                    return i;
                }
            }
            return -1;
        }
             

        //他のクラスに移したほうがいいかも

        /// <summary>
        /// 山札からカードを１枚引く
        /// </summary>
        /// <param name="entity"></param>
        public void Draw(Entity entity)
        {
            int i = entity.MyHand.Countcard;
            entity.Myhand.CardList[i] = entity.MyDeck.CardList[0];
            entity.MyDeck.CardList.Remove(0);

        }





    }
}
