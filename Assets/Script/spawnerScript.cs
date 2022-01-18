using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerScript : MonoBehaviour
{
    Vector2 spawnPos; //spawnPosition
    public GameObject burung;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawner", 20f, 25f); //memunculkan 25 burung, setiap 20detik?
    }

    void spawner()
    {
        spawnPos = new Vector2(-9.8f ,Random.Range(4.5f, 1.45f)); //untuk decalre(deklarasi tempat spawn positionnya)
        Instantiate(burung, spawnPos, Quaternion.identity);
    }
}
