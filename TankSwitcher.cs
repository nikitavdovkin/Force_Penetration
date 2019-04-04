using UnityEngine;

public class TankSwitcher : MonoBehaviour {

    public GameObject tank_1;
    public GameObject tank_2;

    private void Start()
    {
        int id = PlayerPrefs.GetInt("TankPick");
        if (id == 0)
        {
            tank_1.SetActive(true);
            tank_2.SetActive(false);
        }
        if (id == 1)
        {
            tank_2.SetActive(true);
            tank_1.SetActive(false);
        }
    }
}
