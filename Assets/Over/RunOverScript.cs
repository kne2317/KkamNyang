using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class RunOverScript : MonoBehaviour
{
    public GameObject scoreText;
    int score;
    public string nickname = LoginManager.name;
    public string PhoneN = LoginManager.phone;
    public string major = LoginManager.Major;

    public static int rscore = 0;

    void Start()
    {
        //score = director.GetComponent<GameDirector>().point;
        //StartCoroutine(GetScore());
        score = GameDirector.Runpoint;
        //StartCoroutine(GetScore());
        this.scoreText.GetComponent<Text>().text = this.score.ToString() + "  점";
        StartCoroutine(GetScore());
    }

    IEnumerator GetScore()
    {
        WWWForm form = new WWWForm();
        form.AddField("Input_nickname", this.nickname);
        form.AddField("Input_PNum", this.PhoneN);
        form.AddField("Input_major", this.major);
        form.AddField("RunningScore", this.score);

        rscore = this.score;

        using (UnityWebRequest www = UnityWebRequest.Post("http://itshow.dothome.co.kr/GetRunningScore.php", form))
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
