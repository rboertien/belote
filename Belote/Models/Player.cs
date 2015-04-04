using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Belote.Observables;

namespace Belote.Models
{
    class Player : ObservableObject
    {
        private string _name;
        private Hand _hand;

        public Player(string name)
        {
            Name = name;
            _hand = new Hand();
        }

        public Hand Hand
        {
            get { return _hand; }
            set
            {
                if (_hand != value)
                {
                    _hand = value;
                    OnPropertyChanged("Hand");
                }
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        
    }
}
