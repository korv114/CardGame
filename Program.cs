using System;
using System.Collections.Generic;

namespace Main
{

public class Card
{
    public enum Suits
    {
        Hearts = 0,
        Diamonds,
        Clubs,
        Spades
    }

    public int Value
    {
        get;
        set;
    }

    public Suits Suit
    {
        get;
        set;
    }
 }
   
    public Card(int Value, Suits Suit)
    {
        this.Value = Value;
        this.Suit = Suit;
    }
    
    public string NamedValue
    {
        get
        {
            string name = string.Empty;
            switch (Value)
            {
                case (14):
                    name = "Ace";
                    break;
                case (13):
                    name = "King";
                    break;
                case (12):
                    name = "Queen";
                    break;
                case (11):
                    name = "Jack";
                    break;
                default:
                    name = Value.ToString();
                    break;
            }

            return name;
        }
    }
     public string Name
    {
        get
        {
            return NamedValue + " of " + Suit.ToString();
        }
    }
   
public class Deck
{
    public List<Card> Cards = new List<Card>();
    
    public void FillDeck()
        {
          for (int i = 0; i < 52; i++)
          {
             Card.Suits suit = (Card.Suits)((decimal)i/13);
             int val = i%13 + 2;
             Cards.Add(new Card(val, suit));
          }
         }

    public void PrintDeck()
        {
            foreach(Card card in this.Cards)
            {
                Console.WriteLine(card.Name);
            }
            Console.WriteLine("Cards: " + Cards.Count);
         }
    
   public void ShuffleDeck()
         {
            Random rand = new Random();
            for (int i = this.Cards.Count - 1; i > 0; i--)
            {
            int randomIndex = rand.Next(0, i + 1);

            Card temp = this.Cards[i];
            this.Cards[i] = this.Cards[randomIndex];
            this.Cards[randomIndex] = temp;
            }
         }
}
    
static void Main(string[] args)
{

        Deck deck = new Deck();
        deck.FillDeck();
        deck.ShuffleDeck();
        deck.PrintDeck();

    }
}
    
}
