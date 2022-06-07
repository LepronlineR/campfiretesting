using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dice : MonoBehaviour
{

    [SerializeField] Transform[] sides;
    public int chosenSide;
    [SerializeField] TMP_Text dice_text;

    // Update is called once per frame
    void Update() {
        float highest = sides[0].position.y;
        for(int x = 1; x < sides.Length; x++) {
            if(sides[x].position.y > highest){
                highest = sides[x].position.y;
                chosenSide = x+1;
            }
        }
        dice_text.text = chosenSide + "";
    }

    public Rigidbody getRB(){ return GetComponent<Rigidbody>(); }
}
