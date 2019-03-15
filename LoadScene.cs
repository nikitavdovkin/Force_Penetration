using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;


public class LoadScene : MonoBehaviour {
    public void LoadSceneLog()
    {
        SceneManager.LoadScene("firstmap", LoadSceneMode.Single);
        NetworkManagerHUD hud = FindObjectOfType<NetworkManagerHUD>();
        if (hud == null)
            hud.showGUI = true;
    }
}
