using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ChoosePlayer : MonoBehaviour
{
    public static int playerNum;
    public GameObject GoText;

   
    void Start()
    {
        playerNum=0;
    }
   

    public void ClickYH()
    {
        this.GoText.GetComponent<Text>().text = "김윤환 선생님과 함께하기";
        playerNum = 1;
    }
    public void ClickHY()
    {
        this.GoText.GetComponent<Text>().text = "이호연 선생님과 함께하기";
        playerNum = 2;
    }
    public void ClickBS()
    {
        this.GoText.GetComponent<Text>().text = "유병석 선생님과 함께하기";
        playerNum = 3;
    }
    public void ClickNE()
    {
        this.GoText.GetComponent<Text>().text = "고낙은 선생님과 함께하기";
        playerNum = 4;
    }
    public void ClickYC()
    {
        this.GoText.GetComponent<Text>().text = "김영철 선생님과 함께하기";
        playerNum = 5;
    }
    public void ClickJH_eng()
    {
        this.GoText.GetComponent<Text>().text = "김지훈 선생님과 함께하기";
        playerNum = 6;
    }
    public void ClickJH_pro()
    {
        this.GoText.GetComponent<Text>().text = "임정훈 선생님과 함께하기";
        playerNum = 7;
    }
    public void ClickCH()
    {
        this.GoText.GetComponent<Text>().text = "이철호 선생님과 함께하기";
        playerNum = 8;
    }


}
