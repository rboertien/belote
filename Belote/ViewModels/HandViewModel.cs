﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using Belote.Models;

namespace Belote.ViewModels
{
    class HandViewModel
    {
        private static readonly Random _getRandom = new Random();
        private List<Card> _cards;
        public ObservableCollection<Card> Cards { get; set; }

        public HandViewModel()
        {
            InitializeCards();

            Cards = RandomPlayingCards();
        }

        private ObservableCollection<Card> RandomPlayingCards()
        {
            var playingCards = new ObservableCollection<Card>();

            //This will give you 8 unique random values from the 0 to 32 range
            var numbers = Enumerable.Range(0, 32).OrderBy(x => _getRandom.Next()).Take(8);

            for (var i = 0; i < numbers.Count(); i++)
            {
                playingCards.Add(_cards.ElementAt(i));
            }

            return playingCards;
        }

        /// <summary>
        /// Initialize 32 cards into _cards
        /// </summary>
        private void InitializeCards()
        {
            _cards = new List<Card>();
            _cards.Add(new Card { CardColor = "clubs", CardValue = "seven" });
            _cards.Add(new Card { CardColor = "clubs", CardValue = "eight" });
            _cards.Add(new Card { CardColor = "clubs", CardValue = "nine" });
            _cards.Add(new Card { CardColor = "clubs", CardValue = "ten" });
            _cards.Add(new Card { CardColor = "clubs", CardValue = "farmer" });
            _cards.Add(new Card { CardColor = "clubs", CardValue = "queen" });
            _cards.Add(new Card { CardColor = "clubs", CardValue = "king" });
            _cards.Add(new Card { CardColor = "clubs", CardValue = "ace" });

            _cards.Add(new Card { CardColor = "spades", CardValue = "seven" });
            _cards.Add(new Card { CardColor = "spades", CardValue = "eight" });
            _cards.Add(new Card { CardColor = "spades", CardValue = "nine" });
            _cards.Add(new Card { CardColor = "spades", CardValue = "ten" });
            _cards.Add(new Card { CardColor = "spades", CardValue = "farmer" });
            _cards.Add(new Card { CardColor = "spades", CardValue = "queen" });
            _cards.Add(new Card { CardColor = "spades", CardValue = "king" });
            _cards.Add(new Card { CardColor = "spades", CardValue = "ace" });

            _cards.Add(new Card { CardColor = "diamonds", CardValue = "seven" });
            _cards.Add(new Card { CardColor = "diamonds", CardValue = "eight" });
            _cards.Add(new Card { CardColor = "diamonds", CardValue = "nine" });
            _cards.Add(new Card { CardColor = "diamonds", CardValue = "ten" });
            _cards.Add(new Card { CardColor = "diamonds", CardValue = "farmer" });
            _cards.Add(new Card { CardColor = "diamonds", CardValue = "queen" });
            _cards.Add(new Card { CardColor = "diamonds", CardValue = "king" });
            _cards.Add(new Card { CardColor = "diamonds", CardValue = "ace" });

            _cards.Add(new Card { CardColor = "hearts", CardValue = "seven" });
            _cards.Add(new Card { CardColor = "hearts", CardValue = "eight" });
            _cards.Add(new Card { CardColor = "hearts", CardValue = "nine" });
            _cards.Add(new Card { CardColor = "hearts", CardValue = "ten" });
            _cards.Add(new Card { CardColor = "hearts", CardValue = "farmer" });
            _cards.Add(new Card { CardColor = "hearts", CardValue = "queen" });
            _cards.Add(new Card { CardColor = "hearts", CardValue = "king" });
            _cards.Add(new Card { CardColor = "hearts", CardValue = "ace" });
        }
    }
}
