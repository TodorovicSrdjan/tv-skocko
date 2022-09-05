using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSkocko_872019
{
    [Serializable]
    public class GameSave
    {
        public String PlayerName { get; set; }
        public int CurrentRow { get; set; }
        public int CurrentColumn { get; set; }
        public int GameDuration { get; set; }
        public SymbolValue[] Solution { get; set; }
        public SymbolValue[][] LeftGrid { get; set; }
        public GameHistory History { get; set; }
    }
}
