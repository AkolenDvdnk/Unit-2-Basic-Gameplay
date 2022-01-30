using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    public static int Score;
    public static int Lives;

    public int startLives = 3;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;
    public GameObject endGameScreen;

    private void Start()
    {
        Score = 0;
        Lives = startLives;
    }
    private void Update()
    {
        scoreText.text = "Score: " + Score;
        livesText.text = "Lives: " + LivesClamped();
    }
    private int LivesClamped()
    {
        if (Lives <= 0)
        {
            endGameScreen.SetActive(true);
            return 0;
        }
        else
            return Lives;
    }

}
