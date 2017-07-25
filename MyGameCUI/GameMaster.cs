using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameCUI
{
    class GameMaster
    {
        private Stack<Effect> effectStack;

        public GameInfo GameInfo { get; set; }

        public GameMaster()
        {
            GameInfo = new GameInfo();
        }
    }
}
