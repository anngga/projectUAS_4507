using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class burungController : MonoBehaviour
{
    float ms; //movement speed

    // Start is called before the first frame update
    void Start()
    {
        ms = Random.Range(1, 5);
        Invoke("destroyer", 20); //perintah untuk men-destroy game obect=burung, setelah 20detik dari pertama kali dia spawn (muncul)
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, transform.right * 50, Time.deltaTime * ms);
    }

    void destroyer()
    {
        Destroy(gameObject);
    }
}
