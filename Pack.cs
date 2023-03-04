﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        List<Card> pack;

        public Pack()
        {
            pack = new List<Card>();

            var suits = Enumerable.Range(1, 4).ToList();  //1 = Hearts, 2 = Diamonds, 3 = Clubs, 4 = Spades
            var values = Enumerable.Range(1, 13).ToList();  //1-10 normal values eg.(1 = ace, 2 = 2, 3 = 3...), 11 = Jack, 12 = Queen, 13 = King

            foreach (int suit in suits)
            {
                foreach (int value in values)
                {
                    pack.Add(new Card(suit, value));
                }
            }
        }

        public bool shuffleCardPack(int typeOfShuffle)  //FisherYates = 1, 
        {
            //Shuffles the pack based on the type of shuffle

            if (typeOfShuffle == 1)
            {

                Random r = new Random();

                int n = pack.Count;

                while (n > 1)
                {
                    n--;
                    int i = r.Next(n + 1);
                    Card card = pack[i];
                    pack[i] = pack[n];
                    pack[n] = card;
                }

                return true;

            }
            else
            {
                return false;
            }

            

        }
        public Card deal()
        {
            //Deals one card

            if (pack.Count == 0)
            {
                return null;
            }
            
            Card card = pack[0];
            pack.RemoveAt(0);
            return card;


        }
        public List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            if (pack.Count > amount)
            {
                List<Card> returns = null;

                while (amount > 0)
                {
                    returns.Add(deal());
                }
                return returns;
            }
            else
            {
                Console.WriteLine("Not enough cards left in the pack");
                return null;
            }
        }
    }
}