using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [SerializeField] AudioSource audioSource;

    [SerializeField] private AudioClip[] musicSource;

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    public void PlaySound(string name)
    {
        foreach (var clip in musicSource)
        {
            if (clip.name.Contains(name))
            {
                audioSource.clip = clip;
                audioSource.Play();
            }
        }
    }
}
