using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    public void GoStart()
    {
        SceneManager.LoadScene("StartScene");
    }
    public void GoRunWay()
    {
        SceneManager.LoadScene("RunWayScene");
    }
    public void GoBallGameWay()
    {
        SceneManager.LoadScene("BallGameWayScene");
    }
    public void GoTugWay()
    {
        SceneManager.LoadScene("TugWayScene");
    }
    public void GoSelect()
    {
        SceneManager.LoadScene("SelectScene");
    }
    public void StartRunGame()
    {
        SceneManager.LoadScene("Run");
    }
    public void StartBallGame()
    {
        SceneManager.LoadScene("Dodgeball");
    }
    public void StartTugGame()
    {
        SceneManager.LoadScene("Tug");

    }
    public void RunOver()
    {
        SceneManager.LoadScene("RunOver");
    }
    public static void NextRoundTug()
    {
        int r = Random.Range(1, 4);
           
        if (r == 1)
        {
            SceneManager.LoadScene("Tug");
        }else if (r == 2)
        {
            SceneManager.LoadScene("Tug2");
        }
        else
        {
            SceneManager.LoadScene("Tug3");
        }
    }
    
    public void TugOver()
    {
        SceneManager.LoadScene("TugOver");
     }

    public void OXGameStart()
    {
        SceneManager.LoadScene("OX");
    }
    public void OXWay()
    {
        SceneManager.LoadScene("OxWay");
    }
    public void BallT()
    {
        SceneManager.LoadScene("BallT");
    }
    public void RunT()
    {
        SceneManager.LoadScene("RunT");
    }
    public void AllRank()
    {
        SceneManager.LoadScene("AllRank");
    }
    public void BallRank()
    {
        SceneManager.LoadScene("BallRank");
    }
    public void MajorRank()
    {
        SceneManager.LoadScene("MajorRank");
    }
    public void OXRank()
    {
        SceneManager.LoadScene("OXRank");
    }
    public void RunRank()
    {
        SceneManager.LoadScene("RunRank");
    }
    public void TugRank()
    {
        SceneManager.LoadScene("TugRank");
    }

}
