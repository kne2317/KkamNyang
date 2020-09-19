using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OXTimer : MonoBehaviour
{

    public Text timeText;

    public int minutes;
    public int sec;

    int tSeconds = 0;
    int TOTAL_SECONDS = 0;


    GameObject score;

    void Start()
    {

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
        if (sec == 0 && minutes == 0)
        {
            timeText.text = "Over";
            StopCoroutine(second());
            SceneManager.LoadScene("OxOver");

        }
    }
    IEnumerator second()
    {
        yield return new WaitForSeconds(1f);

        if (sec > 0)
            sec--;

        if (sec == 0 && minutes != 0)
        {
            sec = 60;
            minutes--;
        }
        timeText.text = minutes + " : " + sec;
        StartCoroutine(second());
    }
}
