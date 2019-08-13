//2019 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagExample : MonoBehaviour {
    public Text textPieces;
    List<int> pieceBag;

    void Start() {
        pieceBag = new List<int>();
    }

    public void getPiece() {
        if (pieceBag.Count <= 0) {
            refillBag();
        }
        textPieces.text += pieceBag[0];
        pieceBag.RemoveAt(0);
    }

    private void refillBag() {
        int i;
        for (i = 0; i < 7; i++) {
            pieceBag.Insert(Random.Range(0, pieceBag.Count), i);

        }
    }

}
