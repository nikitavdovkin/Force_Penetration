using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;
using System;

public class DBmanager : MonoBehaviour
{
    public new InputField name;
    public InputField pass;
    public new GameObject gameObject; //network ui
    public Text text;
    public int id_;

    public void Log()
    {
        text.text = "";
        StartCoroutine(Login());
    }
    public void Reg()
    {
        text.text = "";
        StartCoroutine(Register());
    }

    public IEnumerator Login()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", name.text);
        WWW download = new WWW("http://nikitos25574.000webhostapp.com/login.php", form);
        yield return download;

        Debug.Log(download.text);
        text.text += download.text + "\n";

        if (download.error != null)
        {
            Debug.Log("Error: " + download.error);
            text.text += "Error: " + download.error + "\n";
            yield break;
        }

        Debug.Log("Server answer: " + download.text);
        text.text += "Server answer: " + download.text + "\n";

        string resultString = Regex.Match(download.text, @"\d+").Value;
        id_ = Int32.Parse(resultString);

        Debug.Log(id_);

        PlayerPrefs.SetInt("id_", id_);

        if (download.text != "User is not found.")
        {
            if (gameObject.active == false)
            {
                gameObject.active = true;
            }
            SceneManager.LoadScene("MapPicker");
        }
        else
        {
            Debug.Log("Bad login.");
        }
    }

    public IEnumerator Register()
    {
        if (name.text != null && pass.text != null && name.text.Length > 4 && pass.text.Length > 4)
        {
            WWWForm form = new WWWForm();
            form.AddField("name", name.text);
            form.AddField("pass", pass.text);
            WWW download = new WWW("http://nikitos25574.000webhostapp.com/register.php", form);
            yield return download;

            Debug.Log(download.text);
            text.text += download.text + "\n";

            if (download.error != null)
            {
                Debug.Log("Error: " + download.error);
                yield break;
            }

            Debug.Log("Server answer: " + download.text);
            text.text += "Server answer: " + download.text + "\n";
        }
        else
        {
            Debug.Log("Username or password are wrong");
            text.text += "username or password are wrong";
        }
    }
}
