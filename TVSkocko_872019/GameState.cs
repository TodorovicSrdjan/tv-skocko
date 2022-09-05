using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSkocko_872019
{
    public class GameState
    {
        public int IndexOfCurrentRow { get; set; }
        public int IndexOfCurrentColumn { get; set; }
        public Symbol ChosenSymbol { get; set; }
    }
}
