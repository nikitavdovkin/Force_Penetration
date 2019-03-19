using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Networking;

public class MapQuit : MonoBehaviour {

    float currCountdownValue;
    public Text text;
    public GameObject NetworkManagerGameObject;

    void Update()
    {
        if(text.text == "Mission Complete" || text.text == "Mission Failed")
        {
            StartCoroutine(StartCountdown());
        }
    }

    public IEnumerator StartCountdown(float countdownValue = 10)
    {
        currCountdownValue = countdownValue;
        while (currCountdownValue > 0)
        {
            yield return new WaitForSeconds(1.0f);
            currCountdownValue--;
        }
        if (currCountdownValue < 1)
        {
            Destroy(NetworkManagerGameObject);
            NetworkManager.Shutdown();
            SceneManager.LoadScene("MapPicker", LoadSceneMode.Single);
        }
    }
}
