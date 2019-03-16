using UnityEngine;

public class Reload : MonoBehaviour {

    public float ReloadSpeed = 2f;
    public float ReloadTimer = 0.0f;

	void Update () 
    {
        if(Input.GetMouseButtonDown(0) & ReloadTimer<=0) 
        { 
            ReloadTimer = ReloadSpeed;  
        }

        if (ReloadTimer > 0)
        {
            ReloadTimer -= Time.deltaTime;
        } 
    }

    void OnGUI()
    {
        int w = Screen.width, h = Screen.height;
        if (ReloadTimer <= 0.1)
        {
            GUI.Box(new Rect(w / 2, h / 2, 100, 30), "Reload: Ready!");
        }
        else
        {
            GUI.Box(new Rect(w / 2, h / 2, 100, 30), "Reload: " + ReloadTimer.ToString("f1"));
        }
    }
}
