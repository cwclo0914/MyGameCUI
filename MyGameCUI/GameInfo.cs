using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameCUI
{
    static class GameInfo
    {
        public static Entity EntityAttacking { get; set; }
        public static Entity EntityDefending { get; set; }
        public static int TurnCount { get; set; }

        public static void Init()
        {
            EntityAttacking = new Entity();
            EntityDefending = new Entity();
            TurnCount = 0;
        }
    }
}
    