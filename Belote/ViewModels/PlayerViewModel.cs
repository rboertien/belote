using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Belote.Observables;
using Belote.Models;
using System.Collections.ObjectModel;

namespace Belote.ViewModels
{
    class PlayerViewModel : ObservableObject
    {
        //private ObservableCollection<Player> _players = new ObservableCollection<Player>();
        //private Player _selectedPlayer;

        public PlayerViewModel()
        {
            Players = new ObservableCollection<Player>();
        }

        public ICollection<Player> Players { get; set; }

        //public Player SelectedPlayer
        //{
        //    get
        //    {
        //        return _selectedPlayer;
        //    }
        //    set
        //    {
        //        _selectedPlayer = value;
        //        OnPropertyChanged("SelectedPlayer");
        //    }
        //}

    }
}
