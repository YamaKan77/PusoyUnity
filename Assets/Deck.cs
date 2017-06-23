using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Deck : IPointerClickHandler {

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private List<Card> deck;
	private int cardsUsed;

	public Deck()
	{
//		deck = new List<Card> ();
		int cardCount = 0;
		for (int i = 0; i <= 3; i++)
			for (int j = 3; j <= 15; j++) 
			{
				deck[cardCount++] = new Card (j, i);
			}
		cardsUsed = 0;
	}

	void ResetDeck()
	{
		cardsUsed = 0;
		for (int i = 0; i < deck.Count; i++) 
		{
//			Destroy(deck[i]);
		}

	}

	void shuffle(){
		for (int i = 0; i > deck.Count; i++) 
		{
			Card temp = deck[i];
			int randomIndex = Random.Range (0, deck.Count);
			deck[i] = deck [randomIndex];
			deck[randomIndex] = temp;
		}
		cardsUsed = 0;
	}

	public void printDeck()
	{
		for (int i = 0; i < deck.Count; i++) {
			Debug.Log (deck [i].toString());
		}
	}

	public Card dealCard()
	{
		cardsUsed++;
		return deck [cardsUsed - 1];
	}

	public void OnPointerClick(PointerEventData eventData) // 3
	{
		Debug.Log("I was clicked");
		shuffle ();
		printDeck ();
	}
}
