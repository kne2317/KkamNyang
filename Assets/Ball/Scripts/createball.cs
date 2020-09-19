using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createball : MonoBehaviour
{
    public GameObject obj;
    public static float LimitTimeB = 0f;
    private float TimeLeft = 5.0f;
    private float nextTime = 0.0f;
    public float LimitTime = 0;
    GameObject b;

    void Start()
    {
        LimitTimeB = 0f;
    }
    void MoveMoles()
    {

        float randomX1 = Random.Range(5, -5);
        float randomY1 = Random.Range(-4, 4);

        b = Instantiate(obj);
        int r = Random.Range(0,5);
        switch (r)
        {
            case 1: b.transform.position = new Vector3(randomX1, -4, 0); break;
            case 2: b.transform.position = new Vector3(randomX1, 4, 0); break;
            case 3: b.transform.position = new Vector3(5, randomY1, 0); break;
            case 4: b.transform.position = new Vector3(-5, randomY1, 0); break;
            default: b.transform.position = new Vector3(randomX1, -4, 0);break;

        }
        
        b.SetActive(true);
        
    }

    void Update()
    {
        // float time = GameObject.Find("Main Camera").GetComponent<Timer>().Update();

        LimitTimeB += Time.deltaTime;
        string str = string.Format("{0:f2}", LimitTimeB);


        //2초마다 실행
        if (Time.time > nextTime)
        {
            nextTime = Time.time + TimeLeft;
            MoveMoles();
        }
        
        if (stopwatch() > 10)
        {
            b.transform.localScale = new Vector3(0.5f, 0.5f, 0);
            obj.transform.localScale = new Vector3(0.5f, 0.5f, 0);
        }
        else if (stopwatch() > 20)
        {
            b.transform.localScale = new Vector3(0.35f, 0.35f, 0);
            obj.transform.localScale = new Vector3(0.35f, 0.35f, 0);
        }
        else if (stopwatch() > 30)
        {
            b.transform.localScale = new Vector3(0.2f, 0.2f, 0);
            obj.transform.localScale = new Vector3(0.2f, 0.2f, 0);
        }
        else if (stopwatch() > 40)
        {
            b.transform.localScale = new Vector3(0.1f, 0.1f, 0);
            obj.transform.localScale = new Vector3(0.1f, 0.1f, 0);
        }

    }
    public double stopwatch()
    {
        LimitTime += Time.deltaTime;
        return Mathf.Round(LimitTime);
    }
}
