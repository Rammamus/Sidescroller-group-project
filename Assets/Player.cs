using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;

    public Rigidbody2D rb;


    public float jumpAmount = 10;

    public GameObject projectile;
    public GameObject projectileClone;
    public AudioScript audioscript;


    float xAngle, yAngle, zAngle;

    bool canJump;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioscript = GameObject.FindObjectOfType<AudioScript>();
    }

    // Update is called once per frame
    void Update()
    {

        fireProjectile();

        //Gubbe gå Vänster - Anton
        if (Input.GetKey(KeyCode.A) && transform.position.x > -11.5f)
                {
                    transform.position += new Vector3(-10, 0, 0) * Time.deltaTime;
                }


                //Gubbe gå Höger - Anton
                if (Input.GetKey(KeyCode.D) && transform.position.x < 11.5f)
                {
                    transform.position += new Vector3(10, 0, 0) * Time.deltaTime;
                }

        transform.Rotate(xAngle, yAngle, zAngle, Space.Self);


        //Gubbe hoppar, om den står på mark och sen sätter canJump till false så att den inte hoppar i luften - Anton
        if (Input.GetKeyDown(KeyCode.Space)&& canJump == true)
                {
                   rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            canJump = false;
            audioscript.Jump();

        }
        

    }

    //Kontrolerar att gubbe står på golv
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            canJump = true;
        }
        if (collision.gameObject.tag == "enemy")
        {
            audioscript.OnHit();
            transform.position = new Vector3(-10, -3.25f, 0);
        }
    }

    // Stjuter projectile - Anton
    void fireProjectile()
    {
        if (Input.GetKeyDown(KeyCode.P) && projectileClone == null)
        {
            audioscript.OnShoot();
            projectileClone = Instantiate(projectile, new Vector3(player.transform.position.x, player.transform.position.y, 0), Quaternion.identity) as GameObject;
        }

       
    }

  
}
