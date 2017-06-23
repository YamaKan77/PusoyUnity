using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card{
	public const int CLUBS = 0;
	public const int DIAMONDS = 1;
	public const int HEARTS = 2;
	public const int SPADES = 3;

	public const int ACE = 14;
	public const int JACK = 11;
	public const int QUEEN = 12;
	public const int KING = 13;

	private int suit;
	private int value;

	public int getSuit 
	{ 
		get 
		{ 
			return suit; 
		} 
	}

	public int getValue
	{
		get
		{
			return value;
		}
	}

	private GameObject card;

	public Card(int _value, int _suit)
	{		
		suit = _suit;
		value = _value;

	}

	public string getSuitAsString() 
	{
		switch (suit)
		{
		case SPADES:
			return "Spades";
		case HEARTS:
			return "Hearts";
		case DIAMONDS:
			return "Diamonds";
		default:
			return "Clubs";
		}
	}

	public string getValueAsString() 
	{
		switch (value) 
		{
		case 14:
			return "Ace";
		case 15:
			return "2";
		case 3:
			return "3";
		case 4:
			return "4";
		case 5:
			return "5";
		case 6:
			return "6";
		case 7:
			return "7";
		case 8:
			return "8";
		case 9:
			return "9";
		case 10:
			return "10";
		case 11:
			return "Jack";
		case 12:
			return "Queen";
		default:
			return "King";
		}
	}

	public string toString()
	{
		return getValueAsString() + " of " + getSuitAsString();
	}
		
}
