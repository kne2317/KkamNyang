using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class ShowRanking : MonoBehaviour
{
    public string nickname = LoginManager.name;
    public string PhoneN = LoginManager.phone;
    public string major = LoginManager.Major;
    //int score = RunOverScript.rscore;

    void Start()
    {
        StartCoroutine(GetScore());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GetScore()
    {
        WWWForm form = new WWWForm();
        form.AddField("Input_nickname", this.nickname);
        form.AddField("Input_PNum", this.PhoneN);
        form.AddField("Input_major", this.major);
      
        using (UnityWebRequest www = UnityWebRequest.Post("http://itshow.dothome.co.kr/ShowRank_running.php", form))
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
