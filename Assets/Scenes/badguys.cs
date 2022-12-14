using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badguys : MonoBehaviour
{

    Vector3 dir;
    int badguysspeed=6;

    // Start is called before the first frame update
    void Start()
    {
        dir = new Vector3(1, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * badguysspeed * Time.deltaTime;//this code makes an obejct move - William A



    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            dir.x = -dir.x;
           //this changes the direction of the obejct
        }
        if (collision.gameObject.tag=="projectile")
        {
            Destroy(this.gameObject);
            //this destroys the obejct if it colides with a gameobejct with the tag projectile
        }
    }
}
