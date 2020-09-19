using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BTimer : MonoBehaviour
{
    public static float LimitTimeB = 0f;
    public Text text_Timer;

    public GameObject readyP;
    void Start()
    {
        LimitTimeB = 0f;
    }

    void Update()
    {
        if (readyP.activeSelf == false)
        {
            LimitTimeB += Time.deltaTime;
            string str = string.Format("{0:f2}", LimitTimeB);
            text_Timer.text = str;
        }

    }
}
