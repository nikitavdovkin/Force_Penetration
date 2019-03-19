using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine;


public class LoadScene : NetworkBehaviour {

    public bool id;

    public void F_Map()
    {
        SceneManager.LoadScene("firstmap", LoadSceneMode.Single);
        NetworkManagerHUD hud = FindObjectOfType<NetworkManagerHUD>();
        if (hud == null)
            hud.showGUI = true;
    }

    public void S_Map()
    {
        SceneManager.LoadScene("secondmap", LoadSceneMode.Single);
        NetworkManagerHUD hud = FindObjectOfType<NetworkManagerHUD>();
        if (hud == null)
            hud.showGUI = true;
    }

    public void T_Map()
    {
        SceneManager.LoadScene("TestField", LoadSceneMode.Single);
        NetworkManagerHUD hud = FindObjectOfType<NetworkManagerHUD>();
        if (hud == null)
            hud.showGUI = true;
    }
}
