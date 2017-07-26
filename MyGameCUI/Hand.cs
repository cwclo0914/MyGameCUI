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


        public void RandomDiscard() { }

        public void ShowUsableCard() { }



        /// <summary>
        /// 手札にカードを１枚加える
        /// </summary>
        /// <param name="card">加えるカード</param>
        public void AddHand(Card card)
        {




        }

        /// <summary>
        /// 手札からカードを１枚出す
        /// </summary>
        /// <returns>出すカード</returns>
        public Card SelectHand()
        {
            int n = -1;

            Console.WriteLine("カードを選んでください");
            try{
                n = int.Parse(Console.ReadLine());
                if (0 <= n && n < CountCard())
                {
                    return RemoveCard(n);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;


        }



    }
}
