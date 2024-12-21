using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] Animator popUp;
    //[SerializeField] Animator popDown;

    public void Pause()
    {
        pauseMenu.SetActive(true);

        popUp.SetTrigger("start");
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        
        StartCoroutine(MenuPop());
    }

    public void Home()
    {
        SceneManager.LoadScene("menu");
    }
    IEnumerator MenuPop()
    {
        popUp.SetTrigger("end");
        
        yield return new WaitForSecondsRealtime(1f);
        pauseMenu.SetActive(false);

        Time.timeScale = 1f;
    }
}
