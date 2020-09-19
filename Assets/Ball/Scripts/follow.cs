using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public GameObject YH;
    public GameObject HY;
    public GameObject BS;
    public GameObject NE;
    public GameObject YC;
    public GameObject JH_eng;
    public GameObject JH_pro;
    public GameObject CH;

    public GameObject YH2;
    public GameObject HY2;
    public GameObject BS2;
    public GameObject NE2;
    public GameObject YC2;
    public GameObject JH_eng2;
    public GameObject JH_pro2;
    public GameObject CH2;

    public static GameObject teacher;
    public static GameObject teacher2;

    void Start()
    {
        switch (ChoosePlayer.playerNum)
        {
            case 1:
                teacher = YH;
                teacher2 = YH2;
                Destroy(HY); Destroy(BS); Destroy(NE); Destroy(YC); Destroy(JH_eng); Destroy(JH_pro); Destroy(CH);
                Destroy(HY2); Destroy(BS2); Destroy(NE2); Destroy(YC2); Destroy(JH_eng2); Destroy(JH_pro2); Destroy(CH2);
                break;
            case 2:
                teacher = HY;
                teacher2 = HY2;
                Destroy(YH); Destroy(BS); Destroy(NE); Destroy(YC); Destroy(JH_eng); Destroy(JH_pro); Destroy(CH);
                Destroy(YH2); Destroy(BS2); Destroy(NE2); Destroy(YC2); Destroy(JH_eng2); Destroy(JH_pro2); Destroy(CH2);
                break;
            case 3:
                teacher = BS;
                teacher2 = BS2;
                Destroy(YH); Destroy(HY); Destroy(NE); Destroy(YC); Destroy(JH_eng); Destroy(JH_pro); Destroy(CH);
                Destroy(YH2); Destroy(HY2); Destroy(NE2); Destroy(YC2); Destroy(JH_eng2); Destroy(JH_pro2); Destroy(CH2);
                break;
            case 4:
                teacher = NE;
                teacher2 = NE2;
                Destroy(YH); Destroy(HY); Destroy(BS);  Destroy(YC); Destroy(JH_eng); Destroy(JH_pro); Destroy(CH);
                Destroy(YH2); Destroy(HY2); Destroy(BS2); Destroy(YC2); Destroy(JH_eng2); Destroy(JH_pro2); Destroy(CH2);
                break;
            case 5:
                teacher = YC;
                teacher2 = YC2;
                Destroy(YH); Destroy(HY); Destroy(BS); Destroy(NE); Destroy(JH_eng); Destroy(JH_pro); Destroy(CH);
                Destroy(YH2); Destroy(HY2); Destroy(BS2); Destroy(NE2); Destroy(JH_eng2); Destroy(JH_pro2); Destroy(CH2);
                break;
            case 6:
                teacher = JH_eng;
                teacher2 = JH_eng2;
                Destroy(YH); Destroy(HY); Destroy(BS); Destroy(NE); Destroy(YC);  Destroy(JH_pro); Destroy(CH);
                Destroy(YH2); Destroy(HY2); Destroy(BS2); Destroy(NE2); Destroy(YC2); Destroy(JH_pro2); Destroy(CH2);
                break;
            case 7:
                teacher = JH_pro;
                teacher2 = JH_pro2;
                Destroy(YH); Destroy(HY); Destroy(BS); Destroy(NE); Destroy(YC); Destroy(JH_eng); Destroy(CH);
                Destroy(YH2); Destroy(HY2); Destroy(BS2); Destroy(NE2); Destroy(YC2); Destroy(JH_eng2); Destroy(CH2);
                break;
            case 8:
                teacher = CH;
                teacher2 = CH2;
                Destroy(YH); Destroy(HY); Destroy(BS); Destroy(NE); Destroy(YC); Destroy(JH_eng); Destroy(JH_pro);
                Destroy(YH2); Destroy(HY2); Destroy(BS2); Destroy(NE2); Destroy(YC2); Destroy(JH_eng2); Destroy(JH_pro2);
                break;
            default:
                teacher = YH;
                teacher2 = YH2;
                Destroy(HY); Destroy(BS); Destroy(NE); Destroy(YC); Destroy(JH_eng); Destroy(JH_pro); Destroy(CH);
                Destroy(HY2); Destroy(BS2); Destroy(NE2); Destroy(YC2); Destroy(JH_eng2); Destroy(JH_pro2); Destroy(CH2);
                break;
        }
        teacher.SetActive(true);
    }
    void Update()
    {
        Vector2 newPosition = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        teacher.transform.position = new Vector2(newPosition.x, newPosition.y);
        teacher2.transform.position = new Vector2(newPosition.x, newPosition.y);
    }

}
