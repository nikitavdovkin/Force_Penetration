using System.Collections;
using UnityEngine;

public class DBmanager : MonoBehaviour
{

    public string userName;
    public string password;

    private void Awake()
    {
    }

    void Start () {
        StartCoroutine(Register());
    }


    IEnumerator Login()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", userName);
        WWW download = new WWW("http://nikitos25574.000webhostapp.com/login.php", form);
        yield return download;
        Debug.Log(download.text);
        if (download.error != null)
        {
            Debug.Log("Error: " + download.error);
            yield break;
        }
        Debug.Log("Server answer: " + download.text);
    }
	
    IEnumerator Register()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", userName);
        form.AddField("pass", password);
        WWW download = new WWW("http://nikitos25574.000webhostapp.com/register.php", form);
        yield return download;
        Debug.Log(download.text);
        if (download.error != null)
        {
            Debug.Log("Error: " + download.error);
            yield break;
        }
        Debug.Log("Server answer: " + download.text);
    }
}
