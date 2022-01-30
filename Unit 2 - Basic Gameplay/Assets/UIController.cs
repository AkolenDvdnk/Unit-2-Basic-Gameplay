using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    public static int Score;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;
    public GameObject endGameScreen;

    private void Start()
    {
        instance = this;

        Score = 0;
    }
    private void Update()
    {
        scoreText.text = "Score: " + Score;
        livesText.text = "Lives: " + LivesClamped();
    }
    private int LivesClamped()
    {
        if (PlayerHealth.Lives <= 0)
        {
            endGameScreen.SetActive(true);
            return 0;
        }
        else
            return PlayerHealth.Lives;
    }
}
