using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCards;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            List<Card> hands = new List<Card>();
            deck.Shuffle();

            for(int i=0; i<5; i++)
            {
                hands.Add(deck.TakeTopCard());
            }
            for(int i=0; i<hands.Count; i++)
            {
                hands[i].FlipOver();
            }
            foreach(Card card in hands)
            {
                card.Print();
            }
            Console.ReadLine();
        }
    }
}
