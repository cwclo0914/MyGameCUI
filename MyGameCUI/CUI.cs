using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameCUI
{
    class CUI
    {
        private GameMaster gameMaster;
        public bool IsGameOver { get; set; }

        public CUI()
        {
            this.gameMaster = new GameMaster();
            IsGameOver = false;
        }

        public void ShowPrompt()
        {
            DescribeGame();
        }

        private void DescribeEntity()
        {

        }

        private void DescribeGame()
        {

        }
    }
}
