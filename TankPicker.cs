using UnityEngine;
using UnityEngine.UI;

public class TankPicker : MonoBehaviour {

    public GameObject tank_1;
    public GameObject tank_2;
    public Text text;
    public Text yourid;
    public GameObject DontDestroy;
    int id;

    public void Start()
    {
        yourid.text = "Your id: " + PlayerPrefs.GetInt("id_").ToString();
    }

    public void LateUpdate () {

        if (Input.GetKeyDown(KeyCode.D))
        {
            tank_1.SetActive(false);
            tank_2.SetActive(true);
            id = 1;
            text.text = "Tank id: 1";
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            tank_2.SetActive(false);
            tank_1.SetActive(true);
            id = 0;
            text.text = "Tank id: 0";
        }

        PlayerPrefs.SetInt("TankPick", id);
    }
}
