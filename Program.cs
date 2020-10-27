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
   
}
