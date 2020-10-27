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
   
   
   
}
