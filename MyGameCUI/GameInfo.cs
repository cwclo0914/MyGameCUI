using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameCUI
{
    class GameInfo
    {
        public Entity Entity1 { get; set; }
        public Entity Entity2 { get; set; }
        public int  TurnCount { get; set; }

        public GameInfo()
        {
            Entity1 = new Entity();
            Entity2 = new Entity();
        }

    }
}
