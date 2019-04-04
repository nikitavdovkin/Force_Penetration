using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour {

    public GameObject DontDestroy;

    private void Awake()
    {
        DontDestroyOnLoad(DontDestroy);
    }
}
