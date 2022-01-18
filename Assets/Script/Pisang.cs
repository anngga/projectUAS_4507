using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pisang : MonoBehaviour
{
    void OnCollisionEnter2D (Collision2D col){
        if (col.gameObject.tag.Equals ("Player")){
            print("pisang diambil");
            Destroy (gameObject);
            BananaScore.hitungPisang += 50;
        }
    }
}
