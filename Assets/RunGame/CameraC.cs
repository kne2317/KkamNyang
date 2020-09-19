using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraC : MonoBehaviour
{
    public GameObject HY;
    public GameObject NE;
    public GameObject JH_pro;
    public GameObject CH;

  
    private void Start()
    {
        
    }

    void Update()
    {
        switch (ChoosePlayer.playerNum)
        {
            case 2:
                Vector3 playerPosHY = this.HY.transform.position;
                transform.position = new Vector3(playerPosHY.x + 5, 0, transform.position.z);
                break;
               
            case 4:
                Vector3 playerPosNE = this.NE.transform.position;
                transform.position = new Vector3(playerPosNE.x + 5, 0, transform.position.z); break;
            case 7:
                Vector3 playerPosJH_pro = this.JH_pro.transform.position;
                transform.position = new Vector3(playerPosJH_pro.x + 5, 0, transform.position.z); break;
            case 8:
                Vector3 playerPosCH = this.CH.transform.position;
                transform.position = new Vector3(playerPosCH.x + 5, 0, transform.position.z); break;
            default:
                Vector3 playerPos = this.HY.transform.position;
                transform.position = new Vector3(playerPos.x + 5, 0, transform.position.z); break;

        }
    }
}
