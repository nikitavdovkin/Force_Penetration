using UnityEngine;

public class MapOFF : MonoBehaviour
{

    public GameObject obj;
    public bool check = false;

	void LateUpdate () {
        if (Input.GetKey(KeyCode.M))
        {
            obj.active = check;
            check =! check;
        }
    }
}
