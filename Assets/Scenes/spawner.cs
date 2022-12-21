using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField]
    GameObject badguy;
    [SerializeField]
    Transform spawnpoint;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(badguy, spawnpoint.position, Quaternion.identity);//spawanar in fienden 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
