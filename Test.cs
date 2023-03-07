using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Test
    {

        Pack pack = new Pack();

        public void shuffle(int typeOfShuffle)
        {
            pack.shuffleCardPack(typeOfShuffle);
        }

        public void dealOne()
        {

            Card d = pack.deal();

            if (d.Suit != 0 || d.Value != 0)
            {
                string v = aquireValue(d);
                string s = aquireSuit(d);

            Console.WriteLine("You got a card \n\n Suit: " + s + "\n Value: " + v + "\n");
            }
        }

        public void dealMultiple(int amount)
        {

            List<Card> cardList = pack.dealCard(amount);

            for(int i = 0; i < cardList.Count; i++)
            {
                Console.WriteLine("Suit for card " + (i + 1) + ": " + aquireSuit(cardList[i]));
                Console.WriteLine("Value for card " + (i + 1) + ": " + aquireValue(cardList[i]) + "\n");
            }
            
        }

        public string aquireValue(Card d)
        {
            
            string v;
            
            if (d.Value == 1)
            {
                v = "Ace";
            }
            else if (d.Value == 11)
            {
                v = "Jack";
            }
            else if (d.Value == 12)
            {
                v = "Queen";
            }
            else if (d.Value == 13)
            {
                v = "King";
            }
            else
            {
                v = d.Value.ToString();
            }

            return v;

        }

        public string aquireSuit(Card d)
        {

            string s;

            if (d.Suit == 1)
            {
                s = "Hearts";
            }
            else if (d.Suit == 2)
            {
                s = "Diamonds";
            }
            else if (d.Suit == 3)
            {
                s = "Clubs";
            }
            else
            {
                s = "Spades";
            }

            return s;

        }

    }
}
