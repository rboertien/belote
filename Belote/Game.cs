using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Belote.Models;

namespace Belote
{
    class Game
    {
        private List<Player> _players;

        public Game()
        {
            _players = new List<Player>();
        }

        internal void Start()
        {
            InitializePlayers();
        }

        internal void Stop()
        {
            // TODO
        }

        internal void Pause()
        {
            // TODO
        }

        private void InitializePlayers()
        {
            _players.Add(new Player("Marleen"));
            _players.Add(new Player("Gerwin"));
            _players.Add(new Player("Geeske"));
            _players.Add(new Player("Fokko"));
        }
    }
}
