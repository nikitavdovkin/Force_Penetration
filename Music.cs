using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioClip audioClip;
    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    
    public void Click()
    {
        audio.PlayOneShot(audioClip);
    }
}