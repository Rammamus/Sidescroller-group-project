using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamerScript : MonoBehaviour
{
    Vector3 dir;

    public AudioScript audioScript;

    public int playerSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        audioScript = GameObject.FindObjectOfType<AudioScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //movement
        if (Input.GetKey(KeyCode.W) && transform.position.y <= 10.49f)
        {
            transform.position += new Vector3(0, playerSpeed, 0) * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S) && transform.position.y >= -10.49f)
        {
            transform.position -= new Vector3(0, playerSpeed, 0) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D) && transform.position.x <= 10.49f)
        {
            transform.position += new Vector3(playerSpeed, 0, 0) * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A) && transform.position.x >= -10.49f)
        {
            transform.position -= new Vector3(playerSpeed, 0, 0) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            audioScript.OnShoot();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            audioScript.OnHit();
        }
    }
}
