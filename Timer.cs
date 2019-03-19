using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text text;
    float currCountdownValue;

    void Start () {
        StartCoroutine(StartCountdown());
    }

    public IEnumerator StartCountdown(float countdownValue = 300)
    {
        currCountdownValue = countdownValue;
        while (currCountdownValue > 0)
        {
            text.text = "Time:" + currCountdownValue.ToString();
            yield return new WaitForSeconds(1.0f);
            currCountdownValue--;
            if (currCountdownValue < 1)
            {
                text.text = "No time";
            }
        }
    }
}
