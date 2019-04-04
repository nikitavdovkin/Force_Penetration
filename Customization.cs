using UnityEngine;

public class Customization : MonoBehaviour {

    public GameObject tank_1;
    public GameObject tank_2;

    public MeshRenderer tank_1_turret;
    public MeshRenderer tank_1_mainbody;
    public MeshRenderer tank_1_barrel;
    public MeshRenderer tank_1_cannon;

    public Material yellow_m;
    public Material black_m;
    int choise;

    public void Awake()
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
    public void FixedUpdate()
    {
        choise = PlayerPrefs.GetInt("Choise");
        if (choise == 1)
        {
            tank_1_turret.GetComponent<MeshRenderer>().material = yellow_m;
            tank_1_mainbody.GetComponent<MeshRenderer>().materials[0] = yellow_m;
            tank_1_mainbody.GetComponent<MeshRenderer>().materials[1] = yellow_m;
            tank_1_barrel.GetComponent<MeshRenderer>().material = yellow_m;
            tank_1_cannon.GetComponent<MeshRenderer>().material = yellow_m;
        }
        else if(choise == 2)
        {
            tank_1_turret.GetComponent<MeshRenderer>().material = black_m;
            tank_1_mainbody.GetComponent<MeshRenderer>().materials[0] = black_m;
            tank_1_mainbody.GetComponent<MeshRenderer>().materials[1] = black_m;
            tank_1_barrel.GetComponent<MeshRenderer>().material = black_m;
            tank_1_cannon.GetComponent<MeshRenderer>().material = black_m;
        }
    }

    public void Yellow_Click()
    {
        choise = 1;
        PlayerPrefs.SetInt("Choise", choise);
    }
    public void Black_Click()
    {
        choise = 2;
        PlayerPrefs.SetInt("Choise", choise);
    }
}
