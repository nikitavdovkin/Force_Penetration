using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DBmanager : MonoBehaviour
{
    public new InputField name;
    public InputField pass;
    public new GameObject gameObject;

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
        if (download.text != "User is not found.")
        {
            if(gameObject.active == false)
            {
                gameObject.active = true;
            }
            SceneManager.LoadScene("firstmap");
        }
        else
        {
            Debug.Log("Bad login.");
        }
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
