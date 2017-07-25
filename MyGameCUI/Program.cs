using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameCUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CUI cui = new CUI();
            do
            {
                cui.ShowPrompt();
            } while (!cui.IsGameOver);
        }
    }
}
