using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LimitTime : MonoBehaviour
{

    public Image Timer;
    public Text timeText;

    public int minutes;
    public int sec;

    public GameObject readyP;

    int tSeconds = 0;
    int TOTAL_SECONDS = 0;


    GameObject score;

    void Start()
    {
        readyP.SetActive(true);
            this.score = GameObject.Find("GameDirector");

            timeText.text = minutes + ":" + sec;
            if (minutes > 0)
                tSeconds += minutes * 60;
            if (sec > 0)
                tSeconds += sec;

            TOTAL_SECONDS = tSeconds;

            StartCoroutine(second());
            
    }

    void Update()
    {
        if (readyP.activeSelf == false)
        {
            if (sec == 0 && minutes == 0)
            {
                timeText.text = "Over";
                StopCoroutine(second());
                GameDirector.Runpoint /= 2;
                SceneManager.LoadScene("RunOver");

            }
        }
    }
    IEnumerator second()
    {
        yield return new WaitForSeconds(1f) ;

        if (sec > 0)
            sec--;

        if (sec == 0 && minutes != 0)
        {
            sec = 60;
            minutes--;
        }
        timeText.text = minutes + ":" + sec;
        fillLoading();
        StartCoroutine(second());
    }
    void fillLoading()
    {
        tSeconds--;
        float fill = (float)tSeconds / TOTAL_SECONDS;
        Timer.fillAmount = fill;
    }
}
