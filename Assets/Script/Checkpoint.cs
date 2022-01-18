using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour
{
    void Win()
    {
        Debug.Log ("Go Go Go!");
        SceneManager.LoadScene ("Main2");
    }

   void OnCollisionEnter2D (Collision2D col){
        if (col.gameObject.tag.Equals ("Player")){
            Win ();
        }
    }
}
