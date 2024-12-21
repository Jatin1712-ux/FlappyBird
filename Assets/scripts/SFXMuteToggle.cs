using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class SFXMuteToggle : MonoBehaviour
{
    Toggle toggle;

    [SerializeField] private AudioSource ASource;

    private GameObject obj;

    private void Start()
    {
       
        obj = GameObject.FindGameObjectWithTag("sound");
        print(obj);
        ASource = obj.GetComponent<AudioSource>();
        toggle = GetComponent<Toggle>();

        if (ASource.mute)
        {
            toggle.isOn = false;
        }

    }

    public void TogglrAudio(bool sfx)
    { 
        if(sfx)
        {
            ASource.mute = false;
        }
        else
        {
            ASource.mute = true;
        }
    }
}
