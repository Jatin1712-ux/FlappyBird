using UnityEngine;

public class BGSound : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("Music");

        if(musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
