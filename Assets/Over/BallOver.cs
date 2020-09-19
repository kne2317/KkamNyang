using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class BallOver : MonoBehaviour
{
    public GameObject scoreText;
    public float time;
    public string nickname = LoginManager.name;
    public string PhoneN = LoginManager.phone;
    public string major = LoginManager.Major;
    public string str;

    void Start()
    {

        time = BTimer.LimitTimeB;
        str = string.Format("{0:f2}", time);
        //StartCoroutine(GetScore());
        this.scoreText.GetComponent<Text>().text = str + "  초";
        StartCoroutine(GetScore());
    }


    IEnumerator GetScore()
    {
        WWWForm form = new WWWForm();
        form.AddField("Input_nickname", this.nickname);
        form.AddField("Input_PNum", this.PhoneN);
        form.AddField("Input_major", this.major);

        form.AddField("PiguScore", this.str);

        using (UnityWebRequest www = UnityWebRequest.Post("http://itshow.dothome.co.kr/GetPiguScore.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                UnityEngine.Debug.Log(www.error);
            }
            else
            {
                UnityEngine.Debug.Log(www.downloadHandler.text);
            }
        }
        yield return null;
    }

}
