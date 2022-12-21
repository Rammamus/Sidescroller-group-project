using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badguys : MonoBehaviour
{

    Vector3 dir;
    int badguysspeed=6;
    public AudioScript audioscript;

    // Start is called before the first frame update
    void Start()
    {
        dir = new Vector3(1, 0, 0);
        audioscript = GameObject.FindObjectOfType<AudioScript>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * badguysspeed * Time.deltaTime;//this code makes an obejct move - William A



    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            dir.x = -dir.x;
           //this changes the direction of the obejct
        }
        if (collision.gameObject.tag=="projectile")
        {
            audioscript.Explosion();
            Destroy(this.gameObject);
            //this destroys the obejct if it colides with a gameobejct with the tag projectile
        }
    }
}
