using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class submitG2 : MonoBehaviour
{
    public Text p1, p2;

    string CreateUserUrl = "addAI.php";

    void Update()
    {
        //Debug.Log(p1.text);

        //Debug.Log(p2.text);
    }

    public void CreateUser()
    {
        WWWForm form = new WWWForm();
        form.AddField("p1", p1.text);
        form.AddField("p2", p2.text);
        form.AddField("gid", 2);

        WWW www = new WWW(CreateUserUrl, form);
    }
}

