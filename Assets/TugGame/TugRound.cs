using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TugRound : MonoBehaviour
{
    public GameObject scoreText;
    void Start()
    {
        scoreText.GetComponent<Text>().text = "Round " + HealthBar.Round.ToString();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneChange.NextRoundTug();
        }
    }

}
