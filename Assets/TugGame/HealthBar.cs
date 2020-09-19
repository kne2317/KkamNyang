using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider helathbar;
    public GameObject readyP;
    public Text roundT;

    public static int deltaT = 3;
    public static int Round = 0;


    public float LimitTime = 0;


    void Start()
    {
        HealthBar.Round++;
        HealthBar.deltaT += 2;

    }
    void Update()
    {
        if (readyP.activeSelf == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                for (int i = 0; i < 50; i++)
                {
                    helathbar.value += 0.05f;
                }
                if (helathbar.value == helathbar.maxValue) { SceneManager.LoadScene("TugRound"); }
            }
            this.roundT.GetComponent<Text>().text = " Round " + HealthBar.Round.ToString();

            if (helathbar.value > 0.0f)
            {
                // 시간이 변경한 만큼 slider Value 변경을 합니다.
                helathbar.value -= (Time.deltaTime * HealthBar.deltaT);
            }
            if (helathbar.value == 0)
            {
                SceneManager.LoadScene("TugOver");
            }
        }
    }



}
