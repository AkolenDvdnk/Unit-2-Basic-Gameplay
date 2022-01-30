using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;

    public GameObject deathEffect;

    private float lowerBound = -10f;
    private float sideBound = 30f;

    private void Update()
    {
        DestroyOutOfBounds();

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    private void DestroyOutOfBounds()
    {
        if (transform.position.z < lowerBound || transform.position.x < -sideBound || transform.position.x > sideBound )
        {
            UIController.Lives--;
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Death();
        if (other.CompareTag("Player"))
        {
            UIController.Lives--;
        }
    }
    private void Death()
    {
        GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, transform.rotation);
        Destroy(effect, 3f);

        UIController.Score++;

        Destroy(gameObject);
    }
}
