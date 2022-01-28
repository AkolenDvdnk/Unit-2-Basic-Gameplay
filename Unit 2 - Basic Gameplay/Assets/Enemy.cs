using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;

    private float lowerBound = -10f;

    private void Update()
    {
        DestroyOutOfBounds();

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    private void DestroyOutOfBounds()
    {
        if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
