using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(10, 0, 0) * Time.deltaTime;



        Destroy(projectile, 2);
    }

    //Destroyar projectilen om den träffar en enemy - Anton
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
           
            Destroy(projectile);
        }

    }

}
