using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceThrower : MonoBehaviour
{
    [SerializeField] Dice[] dices;

    // Start is called before the first frame update
    void Start(){
        foreach(Dice d in dices){
            d.getRB().AddForce(0.0f, Random.Range(0.0f, 50.0f), 0.0f);
            d.getRB().AddTorque(Random.Range(-100.0f, 100.0f), Random.Range(-100.0f, 100.0f), Random.Range(-100.0f, 100.0f));
        }
    }

    public void Roll(){
        foreach(Dice d in dices){
            d.getRB().AddForce(0.0f, Random.Range(1250.0f, 1920.0f), 0.0f);
            d.getRB().AddTorque(Random.Range(-100.0f, 100.0f), Random.Range(-100.0f, 100.0f), Random.Range(-100.0f, 100.0f));
        }
    }
}
