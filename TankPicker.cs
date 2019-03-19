using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class TankPicker : MonoBehaviour {

    public GameObject tank_1;
    public GameObject tank_2;
    public Text text;
    public bool id;

    public void Update () {
        if (Input.GetKeyDown(KeyCode.D))
        {
            tank_1.SetActive(false);
            tank_2.SetActive(true);
            id = true;
            text.text = "Tank id: 1";
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            tank_2.SetActive(false);
            tank_1.SetActive(true);
            id = false;
            text.text = "Tank id: 0";
        }
        using (StreamWriter sw = new StreamWriter(@"D:\text.txt", false, System.Text.Encoding.Default))
        {
            sw.WriteLine(id);
            sw.Close();
        }
    }
}
