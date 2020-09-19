using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ranking_tug : MonoBehaviour
{
    public string nickname = LoginManager.name;
    public string PhoneN = LoginManager.phone;
    public string major = LoginManager.Major;
    //int score = RunOverScript.rscore;

    void Start()
    {
        StartCoroutine(GetScore());
    }


    IEnumerator GetScore()
    {
        WWWForm form = new WWWForm();
        form.AddField("Input_nickname", this.nickname);
        form.AddField("Input_PNum", this.PhoneN);
        form.AddField("Input_major", this.major);

        using (UnityWebRequest www = UnityWebRequest.Post("http://itshow.dothome.co.kr/ShowRank_tug.php", form))
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
