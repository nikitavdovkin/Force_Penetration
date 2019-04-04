using System.Collections;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioClip[] audioClip;

    float currCountdownValue;

    void Start()
    {
        StartCoroutine(StartCountdown());
    }

    public IEnumerator StartCountdown(float countdownValue = 1)
    {
        currCountdownValue = countdownValue;
        while (currCountdownValue > 0)
        {
            yield return new WaitForSeconds(1.0f);
            currCountdownValue++;
            if (currCountdownValue == 2.0)
            {
                GetComponent<AudioSource>().PlayOneShot(audioClip[0]);
            }
            if (currCountdownValue == 70)
            {
                GetComponent<AudioSource>().PlayOneShot(audioClip[1]);
            }
            if (currCountdownValue == 140)
            {
                GetComponent<AudioSource>().PlayOneShot(audioClip[2]);
            }
            if (currCountdownValue == 210)
            {
                GetComponent<AudioSource>().PlayOneShot(audioClip[3]);
            }
            if (currCountdownValue == 280)
            {
                GetComponent<AudioSource>().PlayOneShot(audioClip[4]);
            }
        }
    }

}