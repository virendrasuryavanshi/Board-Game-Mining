using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class submitG1 : MonoBehaviour
{
    public string inputUserName;
    public string inputPassword;
    public string inputEmail;
    public GameObject o1, o2;
    public Text p1, p2;

    string CreateUserUrl = "hk17/updateGame1.php";

    void Start()
    {
       // p1 = i1.GetComponentInChildren<Text>();
       // p2 = i1.GetComponentInChildren<Text>();
    }

    void Update()
    {
        //Debug.Log(p1);

        //Debug.Log(p2.text);
    }

    public void CreateUser()
    {
        WWWForm form = new WWWForm();
        Debug.Log(p1.text);
        Debug.Log(p2.text);

        form.AddField("p1", p1.text);
        form.AddField("p2", p2.text);
        form.AddField("gid", 1);

        Debug.Log(form);

        WWW www = new WWW(CreateUserUrl, form);
        Debug.Log(www.url);

    }
}

