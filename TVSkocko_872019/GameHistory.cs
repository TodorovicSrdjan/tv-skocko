using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSkocko_872019
{
    [Serializable]
    public class GameHistory
    {
        private int iterator = -1;
        private List<GameState> states = new List<GameState>();

        public int Iterator 
        {
            get => iterator;
            set => iterator = value;
        }

        public List<GameState> States
        {
            get => states;
            set => states = value;
        }

        public void AddNewState(GameState state)
        {
            if (iterator == -1)
                states.Clear();
            else if (iterator != states.Count - 1)
            {
                // Remove states after iterator since they are not longer relevant because user has returned to some previous state
                states.RemoveRange(iterator + 1, states.Count - iterator - 1);
            }   
            
            states.Add(state);
            iterator++;
        }

        public GameState SelectPreviousState()
        {
            if (states.Count == 0)
                throw new Exception("History of states is empty");

            return states[iterator--];
        }
        public GameState SelectNextState()
        {
            if (iterator == states.Count - 1)
                throw new Exception("Latest state is already selected");

            return states[++iterator];
        }

        public bool HasPrevious()
        {
            return iterator != -1;
        }

        public bool HasNext()
        {
            return iterator < states.Count - 1;
        }

        public void Clear()
        {
            states.Clear();
            iterator = -1;
        }
    }
}
