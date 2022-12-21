using UnityEngine;

public class BackGround : MonoBehaviour
{
    [Range(-2f, 2f)]
    public float scrollSpeed = -0.5f;

    void Start()
    {

    }

    void Update()
    {
        transform.position += transform.right * scrollSpeed * Time.deltaTime;

        if (transform.position.x < -35)
        {
           transform.position += new Vector3(75, 0, 0);
        }
        

    }
}
