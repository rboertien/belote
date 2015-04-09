using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Belote.Models;
using Belote.ViewModels;

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


        internal void Reset()
        {
            // TODO  reset the game, same as start ?
        }

        internal void Stop()
        {
            // TODO Stop the game
        }

        internal void Pause()
        {
            // TODO
        }

        private void InitializePlayers()
        {
            _players.Add(new Player { Name = "Marleen", Hand = new Hand() });
            _players.Add(new Player { Name = "Gerwin", Hand = new Hand() });
            _players.Add(new Player { Name = "Geeske", Hand = new Hand() });
            _players.Add(new Player { Name = "Fokko", Hand = new Hand() });
        }
    }
}
