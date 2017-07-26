using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameCUI
{
    static class CUI
    {
        public static void ShowMessage(string message, bool waitForInput = true)
        {
            Console.WriteLine(message);
            if (waitForInput)
            {
                Console.Read();
            }
        }

        /*
         * AbstractDeckの中身のカード一覧を表示する。detailedフラグをtrueにすると詳細表示する
         */
        public static void ShowAbstractDeck(AbstractDeck abstDeck, bool detailed = true)
        {
            if (detailed)
            {
                ShowList(abstDeck.CardList.Select(card => card.Name + " Cost: " + card.Cost + "Type: " + card.GetType()).ToList());
            }
            else
            {
                ShowList(abstDeck.CardList.Select(card => card.Name).ToList());
            }
        }

        public static void ShowList(List<string> stringList, bool needsIndex = true)
        {
            for (int i = 0; i < stringList.Count; i++)
            {
                if (needsIndex)
                {
                    Console.Write((i + 1) + ": ");
                }
                Console.WriteLine(stringList[i]);
            }
        }

        private static void DescribeEntity()
        {
        }

        private static void DescribeGame()
        {

        }
    }
}
