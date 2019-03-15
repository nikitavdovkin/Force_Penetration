using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DBmanager : MonoBehaviour
{
    public new InputField name;
    public new InputField pass;

    public void Log()
    {
        StartCoroutine(Login());
    }
    public void Reg()
    {
        StartCoroutine(Register());
    }

    public IEnumerator Login()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", name.text);
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
	
    public IEnumerator Register()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", name.text);
        form.AddField("pass", pass.text);
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
