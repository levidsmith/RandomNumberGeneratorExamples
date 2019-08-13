//2019 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card {

    public string strSuit;
    public string strRank;


    void Start() {
        
    }

    void Update() {
        
    }

    
    public override string ToString() {
        return strRank + " of " + strSuit + "s";

    }
}
