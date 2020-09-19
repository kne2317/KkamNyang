using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class setting : MonoBehaviour
{
    public GameObject set_p;
    private bool isPause = true;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            setting_btn();
        }
    }

    public void setting_btn()
    {
        if (isPause)
        {
            Time.timeScale = 0;
            isPause = false;
        }
      
        set_p.SetActive(true);
    }
    public void close_btn()
    {
        if (isPause==false)
        {
            Time.timeScale = 1;
            isPause = true;
        }
        set_p.SetActive(false);

    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void GoSelect()
    {
        SceneManager.LoadScene("SelectScene");
    }
    public void GoStart()
    {
        SceneManager.LoadScene("StartScene");
    }
    public void OverTug()
    {
        SceneManager.LoadScene("TugOver");
    }
    public void OverRun()
    {
        SceneManager.LoadScene("RunOver");
    }
    public void OverBall()
    {
        SceneManager.LoadScene("BallGOver");
    }
    public void OverOX()
    {
        SceneManager.LoadScene("OXover");
    }
}
