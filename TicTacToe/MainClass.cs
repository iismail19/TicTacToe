using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MainClass m = new MainClass();
            m.Start();
        }

        public void Start()
        {
            SetUp s = new SetUp();
            Game g = new Game(s);
            g.PlayGame();
        }
    }
}
