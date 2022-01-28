using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private float horizontalInput;

    private float boundValue = 10f;

    private void Update()
    {
        LevelBounds(); 

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
    }
    private void LevelBounds()
    {
        if (transform.position.x < -boundValue)
        {
            transform.position = new Vector3(-boundValue, transform.position.y, transform.position.z);
        }
        if (transform.position.x > boundValue)
        {
            transform.position = new Vector3(boundValue, transform.position.y, transform.position.z);
        }
    }
}
