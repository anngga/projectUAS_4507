using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class control : MonoBehaviour
{
    Rigidbody2D rb; //untuk mengambil/memanggil komponen rigidbody2D (disini disingkat menjadi "rb" untuk memudahkan pemanggilan selanjutnya)
    public float ms; //ms = movement speed, untuk kecepatan pergerakan player (kekanan, atau kekiri) dalam float/ bilangan desimal
    public float jumpForce; //untuk lompat

    public LayerMask ground; 
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();//memanggil komponen rigidbody yang sudah dimasukkan ke dalam object player(monkey)
    }

    // Update is called once per frame
    void Update()
    {
        float horiz = Input.GetAxisRaw("Horizontal"); //jika kita input (pada keyboard) a, [atau] arrow kiri = -1 || d, [atau] arrow kanan = 1
        rb.velocity = new Vector2(horiz * ms, rb.velocity.y);

        //kode dibawah ini digunakan untuk player, agar bisa menghadap kanan atau kiri mengikuti inputan keyboard
        if (horiz > 0 || horiz < 0)
        {
            transform.localScale = new Vector2 (0.3924644f * horiz, 0.3924644f);
        }

        if (Input.GetKeyUp(KeyCode.Space))//jika kita tekan space/spasi maka...
        {
            
            
                rb.velocity = Vector2.up * jumpForce;
            
        }
    }

    bool IsGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1.0f;

        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, ground);
        if (hit.collider != null)
        {
            return true;
        }
        return false;
    }
}