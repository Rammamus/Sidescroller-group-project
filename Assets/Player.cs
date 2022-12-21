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


    float xAngle, yAngle, zAngle;

    bool canJump;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        fireProjectile();

        //Gubbe g� V�nster - Anton
        if (Input.GetKey(KeyCode.A))
                {
                    transform.position += new Vector3(-10, 0, 0) * Time.deltaTime;
                }


                //Gubbe g� H�ger - Anton
                if (Input.GetKey(KeyCode.D))
                {
                    transform.position += new Vector3(10, 0, 0) * Time.deltaTime;
                }

        transform.Rotate(xAngle, yAngle, zAngle, Space.Self);


        //Gubbe hoppar, om den st�r p� mark och sen s�tter canJump till false s� att den inte hoppar i luften - Anton
        if (Input.GetKeyDown(KeyCode.Space)&& canJump == true)
                {
                   rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            canJump = false;
                }
        

    }

    //Kontrolerar att gubbe st�r p� golv
    void OnCollisionEnter2D()
    {
        canJump = true;
    }

    // Stjuter projectile - Anton
    void fireProjectile()
    {
        if (Input.GetKeyDown(KeyCode.P) && projectileClone == null)
        {
            projectileClone = Instantiate(projectile, new Vector3(player.transform.position.x, player.transform.position.y, 0), Quaternion.identity) as GameObject;
        }

       
    }

  
}
