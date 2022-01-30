using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public int startHealth;

    public Slider healthBar;
    public GameObject deathEffect;

    private int health;

    private void Start()
    {
        health = startHealth;
        healthBar.maxValue = startHealth;
    }
    public void TakeDamage(int damage)
    {
        health -= damage;

        healthBar.value = health;

        if (health <= 0)
        {
            Death();
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
