using UnityEngine;

[RequireComponent(typeof(EnemyHealth))]
public class Enemy : MonoBehaviour
{
    public float speed;

    private float lowerBound = -10f;
    private float sideBound = 30f;

    private EnemyHealth enemyHealth;

    private void Awake()
    {
        enemyHealth = GetComponent<EnemyHealth>();
    }
    private void Update()
    {
        DestroyOutOfBounds();

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    private void DestroyOutOfBounds()
    {
        if (transform.position.z < lowerBound || transform.position.x < -sideBound || transform.position.x > sideBound )
        {
            PlayerHealth.Lives--;
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        enemyHealth.TakeDamage(1);
        if (other.CompareTag("Player"))
        {
            PlayerHealth.Lives--;
        }
    }
}
