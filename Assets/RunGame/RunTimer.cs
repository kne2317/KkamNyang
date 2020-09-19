using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class  RunTimer : MonoBehaviour
{
    public static float LimitTimeB = 0f;
    public Text text_Timer;
    void Start()
    {
        LimitTimeB = 0f;
    }

    void Update()
    {

        LimitTimeB += Time.deltaTime;
        string str = string.Format("{0:f2}", LimitTimeB);
        text_Timer.text = "시간 : " + str;


    }
}
