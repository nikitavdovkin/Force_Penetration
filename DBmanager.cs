using System.Collections;
using UnityEngine;

public class DBmanager : MonoBehaviour {

    public string userName;
    public string password;



    void Start () {
        StartCoroutine(GetUser());
	}
	
    private IEnumerator RegisterUser()
    {
        WWWForm form = new WWWForm();
        form.AddField("Name: ", userName);
        form.AddField("Password: ", password);
        WWW www = new WWW("https://nikitos25574.000webhostapp.com/Force%20Penetration/register.php", form);
        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        Debug.Log("Server answer: " + www.text);
    }

    private IEnumerator GetUser()
    {
        WWWForm form = new WWWForm();
        form.AddField("Name: ", userName);
        WWW www = new WWW("https://nikitos25574.000webhostapp.com/Force%20Penetration/login.php", form);
        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        Debug.Log("Server answer: " + www.text);
    }
}
