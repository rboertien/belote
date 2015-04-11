using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Belote.Observables;
using Belote.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Belote.Helpers;

namespace Belote.ViewModels
{
    class PlayerViewModel : ObservableObject
    {
        //private ObservableCollection<Player> _players = new ObservableCollection<Player>();
        private Player _selectedPlayer;

        public ICollection<Player> Players { get; set; }

        public PlayerViewModel()
        {
            Players = new ObservableCollection<Player>();
        }

        public ICommand AddCommand
        {
            get
            {
                return new ActionCommand(p => AddPlayer()); //(p => AddPlayer(), p => IsValid);
            }
        }

        private void AddPlayer()
        {
            Players.Add(new Player { Name = "Marleen", Hand = new Hand() });

            var index = Players.Count -1;

            SelectedPlayer = Players.ElementAt(index);
        }

        public Player SelectedPlayer
        {
            get
            {
                return _selectedPlayer;
            }
            set
            {
                if (_selectedPlayer != value)
                {
                    _selectedPlayer = value;
                    OnPropertyChanged("SelectedPlayer");
                }
            }
        }
    }
}
