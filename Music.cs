using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioClip audioClip;
    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
            audio.PlayOneShot(audioClip);
        if (Input.GetKeyUp(KeyCode.DownArrow))
            audio.Stop();
    }
}