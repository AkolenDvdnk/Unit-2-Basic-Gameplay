using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static int Lives;

    public int startLives = 3;

    public GameObject endGameScreen;
    public GameObject deathEffect;
    public GameObject player;

    private void Start()
    {
        Lives = startLives;
    }
    private void Update()
    {
        Death();
    }
    public void Death()
    {
        if (Lives <= 0)
        {
            endGameScreen.SetActive(true);
            GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, transform.rotation);
            Destroy(effect, 3f);

            player.SetActive(false);
        }
    }
    public static int LivesClamped()
    {
        if (Lives <= 0)
        {
            return 0;
        }
        else
            return Lives;
    }
}
