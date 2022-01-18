using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
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

        if(Input.GetKeyUp(KeyCode.Space))//jika kita tekan space/spasi maka...
        {
            if (!IsGrounded()) //jika ada ground (daratan)..
            //(2) jika grounded..
            {
                return;//maka, akan diam / tertarik ke bawah (gravitasi)
                //(2) maka akan di return
            }
            else // jika tidak ada ground (daratan)..
            //(2)jika tidak grounded..
            {
                rb.velocity = Vector2.up * jumpForce; //maka dia (player/monkey) akan loncat
                //(2) maka dia akan loncat
            }
        }
    }
    
    bool IsGrounded() //agar player tidak lompat ke atas terlalu tinggi (terbang)
    {
        Vector2 position = transform.position; //posisi awal (player)
        Vector2 direction = Vector2.down; // direction
        float distance = 1.0f; //distance

        //RaycastHit2D = untuk menembakan semacam laser (gravitasi)
        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, ground); //komponen yang ada dalam RaycastHit2D
        /*
            position = origin, posisi awal (transform.position)
            ground = kita cek apakah ada ground atau tidak? jika iya, maka player akan ter-tarik ke bawah
        */    
        if (hit.collider != null)
        {
            return true;
        }
        return false;
    }
}
