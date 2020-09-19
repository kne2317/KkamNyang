using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject player;
    GameObject pointText;
    public static int Runpoint = 0;
    GameObject generator;

    public GameObject HY;
    public GameObject NE;
    public GameObject JH_pro;
    public GameObject CH;

    public GameObject comboText;

    int combo = 0;

    void Start()
    {
        this.generator = GameObject.Find("ItemGenerator");
        this.pointText = GameObject.Find("scoreText");
        switch (ChoosePlayer.playerNum)
        {
            
            case 2:
                HY.SetActive(true);
                Destroy(NE); Destroy(JH_pro); Destroy(CH); break;
            case 4:
                NE.SetActive(true);
                Destroy(HY); Destroy(JH_pro); Destroy(CH); break;
            case 7:
                JH_pro.SetActive(true);
                Destroy(HY); Destroy(NE); Destroy(CH); break;
            case 8:
                CH.SetActive(true);
                Destroy(HY); Destroy(JH_pro); Destroy(NE); break;
            default:
                HY.SetActive(true);
                Destroy(NE); Destroy(JH_pro); Destroy(CH); break;

        }


    }

    void Update()
    {
        this.pointText.GetComponent<Text>().text = Runpoint.ToString() + " 점";
      
    }
    public void PlusScore()
    {
        Runpoint += 100;
        
        combo++;
        this.comboText.GetComponent<Text>().text = "combo\n" + this.combo.ToString();
        if (combo>= 5)
        {
            combo = 0;
            Runpoint += 400;
            this.comboText.GetComponent<Text>().text = "combo\n" + "bonus";
        }
       
    }

    public void MinusScore()
    {
        Runpoint -= 50;

        combo = 0;
        this.comboText.GetComponent<Text>().text = "combo\n" + this.combo.ToString();

        float _time = 0.0f;

        _time += Time.deltaTime;
    }
    IEnumerator Disabled(float waitTime, GameObject t)
    {
        yield return new WaitForSeconds(waitTime);
        t.SetActive(false);
    }
}
