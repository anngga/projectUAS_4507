using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bintangController : MonoBehaviour
{
    void OnCollisionEnter2D (Collision2D col){
        if (col.gameObject.tag.Equals ("Player")){
            Debug.Log ("Bonus Round");
            SceneManager.LoadScene ("BonusRound");
        }
    }
}
