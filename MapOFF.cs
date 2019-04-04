using System.Collections;
using UnityEngine;

public class MapOFF : MonoBehaviour
{

    public GameObject obj;
    bool check = false;
    float currCountdownValue;

    void LateUpdate () {
        if (Input.GetKeyDown(KeyCode.M))
        {
            StartCoroutine(StartCountdown());
        }
    }

    public IEnumerator StartCountdown(float countdownValue = 1)
    {
        currCountdownValue = countdownValue;
        while (currCountdownValue > 0)
        {
            yield return new WaitForSeconds(1.0f);
            currCountdownValue--;
            if (currCountdownValue < 1)
            {
                obj.SetActive(check);
                check = !check;
            }
        }
    }
}
