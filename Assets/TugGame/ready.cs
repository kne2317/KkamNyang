using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ready : MonoBehaviour
{
    public GameObject readyText;
    public GameObject Ready;
    void Start()
    {
        int r = HealthBar.Round + 1;
        this.readyText.GetComponent<Text>().text = "Round " +r+"\nready";
        StartCoroutine(ShowReady());
    }

    IEnumerator ShowReady()
    {
        Ready.SetActive(true);
        int count = 0;
        while (count < 3)
        {
            readyText.SetActive(true);
            yield return new WaitForSeconds(0.5f);

            readyText.SetActive(false);

            yield return new WaitForSeconds(0.5f);
            count++;
        }
        Ready.SetActive(false);
    }


}

