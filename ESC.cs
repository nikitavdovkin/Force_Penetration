using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class ESC : MonoBehaviour
{

    public GameObject NetworkManagerGameObject;

    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Destroy(NetworkManagerGameObject);
            NetworkManager.Shutdown();
            SceneManager.LoadScene("MapPicker", LoadSceneMode.Single);
            NetworkManagerHUD hud = FindObjectOfType<NetworkManagerHUD>();
            if (hud != null)
            {
                hud.showGUI = false;
            }
        }
    }      
}
