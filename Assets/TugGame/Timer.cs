using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float LimitTime=0f;
    public GameObject readyP;
    public Text text_Timer;
    void Start()
    {
    }

    void Update()
    {
        if (readyP.activeSelf == false)
        {
            
            LimitTime += Time.deltaTime;
            string str = string.Format("{0:f2}", LimitTime);
            text_Timer.text = "시간 : " + str;

        }
       
    }
}
