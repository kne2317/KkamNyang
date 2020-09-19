using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TugOverScript : MonoBehaviour
{
    public GameObject scoreText;
    float time;
    void Start()
    {
       
        scoreText.GetComponent<Text>().text = "Round " + HealthBar.Round.ToString();
        HealthBar.Round = 0;
    }

    void Update()
    {

    }
}
