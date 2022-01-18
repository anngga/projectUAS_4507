using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int health;
    [SerializeField] Slider HealthBar;


    private void Update()
    {
        HealthBar.value = health;

        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            TakeDamage();
        }else if (other.CompareTag("bird"))
        {
            TakeDamage();
        }
    }

    public void TakeDamage()
    {
        health -= 1;
    }

    void Die()
    {
        Debug.Log ("GAME OVER");
        SceneManager.LoadScene ("Main2");
    }
}
