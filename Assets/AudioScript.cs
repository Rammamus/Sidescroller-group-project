using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioScript : MonoBehaviour
{
    public AudioSource hitAudio;
    public AudioSource shootAudio;
    public AudioSource jump;
    public AudioSource explosion;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            hitAudio.Play();
        }
    }

    // This function is called when the character gets hit - Adrian
    public void OnHit()
    {
        hitAudio.Play();
    }
    public void OnShoot()
    {
        shootAudio.Play();
    }
    public void Jump()
    {
        jump.Play();
    }
    public void Explosion()
    {
        explosion.Play();
    }
}