using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NRT : MonoBehaviour
{
    void Start()
    {
        NRT_space();
    }
    public void NRT_space()
    {
        int r = Random.Range(1, 4);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (r == 1)
            {
                SceneManager.LoadScene("Tug");
            }
            else if (r == 2)
            {
                SceneManager.LoadScene("Tug2");
            }
            else
            {
                SceneManager.LoadScene("Tug3");
            }
        }
    }
}
