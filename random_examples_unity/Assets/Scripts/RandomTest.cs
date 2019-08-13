//2019 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTest : MonoBehaviour {
    List<Card> deck;

    void Start () {

    }

    void Update () {

    }

    public void doCoinFlip () {
        bool isHeads = false;
        int iRandom;

        iRandom = Random.Range (0, 2);
        if (iRandom == 0) {
            isHeads = false;
        } else if (iRandom == 1) {
            isHeads = true;
        }

        if (isHeads) {
            Debug.Log ("Heads");
        } else {
            Debug.Log ("Tails");
        }
    }

    public void doRockPaperScissors () {
        int iRandom;
        iRandom = Random.Range (0, 3);
        switch (iRandom) {
            case 0:
                Debug.Log ("Rock");
                break;
            case 1:
                Debug.Log ("Paper");
                break;
            case 2:
                Debug.Log ("Scissors");
                break;

        }
    }

    public void doDiceRoll () {
        int iRandom;
        int iSides;

        iSides = 6;
        iRandom = Random.Range (1, iSides + 1);
        Debug.Log ("6 sided die: Rolled a " + iRandom);

        iSides = 20;
        iRandom = Random.Range (1, iSides + 1);
        Debug.Log ("20 sided die: Rolled a " + iRandom);

    }

    public void makeDeck () {
        int i, j;
        deck = new List<Card> ();
        for (i = 0; i < 4; i++) {
            for (j = 1; j <= 13; j++) {
               Card c = new Card ();
               if (i == 0) {
                   c.strSuit = "Spade";
               } else if (i == 1) {
                   c.strSuit = "Club";
               } else if (i == 2) {
                   c.strSuit = "Heart";
               } else if (i == 3) {
                   c.strSuit = "Diamond";
               }

                if (j == 1) {
                    c.strRank = "Ace";
                } else if (j >= 2 && j <= 10) {
                    c.strRank = j.ToString();
                } else if (j == 11) {
                    c.strRank = "Jack";
                } else if (j == 12) {
                    c.strRank = "Queen";
                } else if (j == 13) {
                    c.strRank = "King";
                }
                deck.Add(c);

            }
        }
        shuffleDeck();
    }

    private void shuffleDeck() {
        List<Card> shuffledDeck = new List<Card>();
        while(deck.Count > 0) {
            int iRandom = Random.Range(0, deck.Count);
            Card c = deck[iRandom];
            shuffledDeck.Add(c);
            deck.Remove(c);
        }
        deck = shuffledDeck;
    }

    public void doDrawCard() {
        if (deck != null && deck.Count > 0) {
            Card c = deck[0];
            Debug.Log("Drew " + c.ToString());
            deck.RemoveAt(0);
            Debug.Log(deck.Count + " cards left in deck");
            
        } else {
            Debug.Log("Deck is empty!");
        }
    }


    public void printRandomNumbers() {
        string strResult = "";

        int i;
        for (i = 0; i < 10; i++) {
            strResult += Random.Range(1, 100) + ", ";
        }

        Debug.Log(strResult);

    }


    public void printRandomNumbersSeed() {
        Random.InitState(0);

//        Random.InitState(1337);
        string strResult = "";

        int i;
        for (i = 0; i < 10; i++) {
            strResult += Random.Range(1, 100) + ", ";
        }

        Debug.Log(strResult);

    }


}