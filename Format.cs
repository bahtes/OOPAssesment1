using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Format  //Format class to format the output of the Pack class into a readable format
    {

        Pack pack = new Pack();  //Creates a new instance of the Pack class

        public void shuffle(int typeOfShuffle)  //Shuffles the pack based on the type of shuffle
        {
            if (Pack.shuffleCardPack(typeOfShuffle))
            {
                Console.WriteLine("Shuffle successful\n");
            }
            else 
            {
                Console.WriteLine("Shuffle unsuccessful suspected incorrect input\n");
            } 
        }

        public void dealOne()  //Deals one card from the pack
        {

            Card d = Pack.deal();

            if (d.Suit != 0 || d.Value != 0)  //Checks if the card is not a null card
            {
                string v = aquireValue(d);
                string s = aquireSuit(d);

            Console.WriteLine("You got a card \n\n Suit: " + s + "\n Value: " + v + "\n");
            }
            else
            {
                Console.WriteLine("No cards left in the pack\n");
            }

        }

        public void dealMultiple(int amount)  //Deals multiple cards from the pack
        {

            List<Card> cardList = Pack.dealCard(amount);

            if (cardList.Count != 0)
            {

                for(int i = 0; i < cardList.Count; i++)
                {
                    Console.WriteLine("Suit for card " + (i + 1) + ": " + aquireSuit(cardList[i]));
                    Console.WriteLine("Value for card " + (i + 1) + ": " + aquireValue(cardList[i]) + "\n");
                }
            }
            else
            {
                Console.WriteLine("Not enough cards left in the pack\n");
            }

            
            
        }

        public string aquireValue(Card d)  //Aquires the value of the card and returns it as a string, eg. 1 = Ace, 11 = Jack, 12 = Queen, 13 = King
        {
            
            string v;

            switch (d.Value)
            {
                case 1:
                    v = "Ace";
                    break;
                case 11:

                    v = "Jack";
                    break;

                case 12:
                    v = "Queen";
                    break;

                case 13:
                    v = "King";
                    break;

                default:
                    v = d.Value.ToString();
                    break;
            }

            return v;

        }

        public string aquireSuit(Card d)  //Aquires the suit of the card and returns it as a string, eg. 1 = Hearts, 2 = Diamonds, 3 = Clubs, 4 = Spades
        {

            string s;

            switch (d.Suit)
            {
                case 1:
                    s = "Hearts";
                    break;

                case 2:
                    s = "Diamonds";
                    break;

                case 3:
                    s = "Clubs";
                    break;

                case 4:
                    s = "Spades";
                    break;

                default:
                    s = "Error";
                    break;
            }

            return s;

        }

    }
}