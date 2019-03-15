using UnityEngine;
using UnityEngine.SceneManagement;

public class ESC : MonoBehaviour {
    public GameObject exit;
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
            UnityEngine.Networking.NetworkManagerHUD hud = FindObjectOfType<UnityEngine.Networking.NetworkManagerHUD>();
            if (hud != null)
                hud.showGUI = false;
        }
    }
        
}
