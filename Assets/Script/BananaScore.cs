using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BananaScore : MonoBehaviour
{
    public static int hitungPisang;
    Text hitungPisangText;

    // Start is called before the first frame update
    void Start()
    {
        hitungPisang = 0;
        hitungPisangText = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        hitungPisangText.text = hitungPisang.ToString ();
    }
}
