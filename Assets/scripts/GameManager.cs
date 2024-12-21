using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private player player;
    private spawner spawner;

    public int GameScore = 0;
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    public GameObject returnButton;
    public int score { get; private set; }

    private void Start()
    {
        Application.targetFrameRate = 60;

        player = FindObjectOfType<player>();
        spawner = FindObjectOfType<spawner>();
        gameOver.SetActive(false);
        Pause();
    }

    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for (int i = 0; i < pipes.Length; i++) {
            Destroy(pipes[i].gameObject);
        }
    }

    public void GameOver()
    {
        playButton.SetActive(true);
        gameOver.SetActive(true);

        Pause();
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void ReturnButton()
    {
        returnButton.SetActive(true);
        AudioManager.Instance.PlaySound("Click");
        var old_score = PlayerPrefs.GetInt("highscore", 0);
        if (old_score < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
        SceneManager.LoadScene("menu");
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
    

}
