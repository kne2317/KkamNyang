using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class OxOver : MonoBehaviour
{
    public GameObject scoreText;
    int score;
    public string nickname = LoginManager.name;
    public string PhoneN = LoginManager.phone;
    public string major = LoginManager.Major;

    void Start()
    {
        score = OXGame.scoreOX;
        StartCoroutine(GetScore());
        this.scoreText.GetComponent<Text>().text = score + "점";
        Sound.aud.Play();
    }

    IEnumerator GetScore()
    {
        WWWForm form = new WWWForm();
        form.AddField("Input_nickname", this.nickname);
        form.AddField("Input_PNum", this.PhoneN);
        form.AddField("Input_major", this.major);
        form.AddField("OXScore", this.score);

        using (UnityWebRequest www = UnityWebRequest.Post("http://itshow.dothome.co.kr/GetOXQuizScore.php", form))
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
