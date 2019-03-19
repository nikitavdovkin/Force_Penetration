using System.IO;
using UnityEngine;

public class TankSwitcher : MonoBehaviour {

    public GameObject tank_1;
    public GameObject tank_2;
    string text;

    private void Start()
    {
        using (StreamReader sr = new StreamReader(@"D:\text.txt", System.Text.Encoding.Default))
        {
            text = sr.ReadToEnd();
            sr.Close();
        }
        if (text.Contains("False"))
        {
            tank_1.SetActive(true);
            tank_2.SetActive(false);
        }
        if (text.Contains("True"))
        {
            tank_2.SetActive(true);
            tank_1.SetActive(false);
        }
    }
}
