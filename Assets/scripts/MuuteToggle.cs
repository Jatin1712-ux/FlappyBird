using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]

public class MuuteToggle : MonoBehaviour
{
    Toggle myToggle;

    [SerializeField] private AudioSource audioSource;

    private GameObject Object;



    private void Start()
    {
        Object = GameObject.FindGameObjectWithTag("Music");
        audioSource = Object.GetComponent<AudioSource>();
        myToggle = GetComponent<Toggle>();
        if(audioSource.mute) 
        {           
            myToggle.isOn = false;
        }
        
        
    }

    public void ToggleAudioOnValueChange(bool audioIn)
    {
        if (audioIn)
        {
           
            audioSource.mute = false;
        }
        else
        {
            
            audioSource.mute = true;
        }
    }

}
