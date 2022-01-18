using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    void Win()
    {
        Debug.Log ("You Win!");
        SceneManager.LoadScene ("Win");
    }

   void OnCollisionEnter2D (Collision2D col){
        if (col.gameObject.tag.Equals ("Player")){
            Win ();
        }
    }
}
