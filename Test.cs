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

        public void dealOne()
        {
            
            pack.shuffleCardPack(1);

            Console.WriteLine("Pack is randomally shuffled would you like to deal yourself a single card or multiple: \n");

            Card d = pack.deal();
            
            string v = aquireValue(d);
            string s = aquireSuit(d);

            Console.WriteLine("You got a card \n\n Suit: " + s + "\n Value: " + v + "\n");
        }

        public void dealMultiple()
        {

            List<Card> cardList = pack.dealCard(5);

            for(int i = 0; i < cardList.Count; i++)
            {
                Console.WriteLine("Suit for card " + i + ": " + aquireSuit(cardList[i]));
                Console.WriteLine("Value for card " + i + ": " + aquireValue(cardList[i]) + "\n");
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
