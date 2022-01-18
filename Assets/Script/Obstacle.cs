using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    void Die()
    {
        Debug.Log ("GAME OVER");
        SceneManager.LoadScene ("Main");
    }

   void OnCollisionEnter2D (Collision2D col){
        if (col.gameObject.tag.Equals ("Player")){
            Die ();
        }
    }
}
