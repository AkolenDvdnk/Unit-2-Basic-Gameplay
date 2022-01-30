using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;

    private float topBound = 30f;

    private void Update()
    {
        DestroyOutOfBounds();

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    private void DestroyOutOfBounds()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
