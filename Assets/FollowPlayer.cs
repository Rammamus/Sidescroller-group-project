using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this code makes camera follow player on only Y-axis
public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        player = GameObject.FindWithTag("Player");
        transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
    }
}
