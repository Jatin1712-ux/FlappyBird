using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenuScript : MonoBehaviour
{
    public Text HStext;

    private void Start()
    {
        HStext.text = PlayerPrefs.GetInt("highscore", 0).ToString();

    }

    public void StartButton()
    {
        SceneManager.LoadScene("game");
    }

}
