using Belote.Observables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Belote.Models
{
    class Player : ObservableObject
    {
        public Hand Hand { get; set; }

        private string _name;

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
