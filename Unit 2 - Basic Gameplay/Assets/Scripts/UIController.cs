using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    public static int Score;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;

    private void Start()
    {
        instance = this;

        Score = 0;
    }
    private void Update()
    {
        scoreText.text = "Score: " + Score;
        livesText.text = "Lives: " + PlayerHealth.LivesClamped();

        Quit();
    }
    private void Quit()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
