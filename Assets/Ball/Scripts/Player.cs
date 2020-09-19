using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    public Vector2 speed_vec;

    public GameObject readyP;

    private int count = 3;
    Collider col;

    public GameObject obj;
    public float LimitTime = 0;

    float timeImg;

    void Update() 
    {
        MoveObject();
    }

    void MoveObject()
    {
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);

        if (pos.x < 0f) pos.x = 0f;
        if (pos.x > 1f) pos.x = 1f;
        if (pos.y < 0f) pos.y = 0f;
        if (pos.y > 1f) pos.y = 1f;

        transform.position = Camera.main.ViewportToWorldPoint(pos);

        GetComponent<Rigidbody2D>().velocity = speed_vec;
    }

    float stopwatch()
    {
        LimitTime += Time.deltaTime;
        return Mathf.Round(LimitTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject heart1 = GameObject.Find("heart_1");
        GameObject heart2 = GameObject.Find("heart_2");
        GameObject heart3 = GameObject.Find("heart_3");
       
        if (other.gameObject.tag.Equals("ball"))
        //부딪힌 객체의 태그를 비교해서 적인지 판단
        {
            if (count == 3)
            {
                Destroy(heart3.gameObject);
                triggerBall();
            }
            else if (count == 2)
            {
                Destroy(heart2.gameObject);
                triggerBall();
            }
            else if (count == 1)
            {
                Destroy(heart1.gameObject);
                SceneManager.LoadScene("BallGOver");
            }
            count -= 1;
        }
    }
    void triggerBall()
    {
        Destroy(GameObject.FindWithTag("ball"));
        follow.teacher2.SetActive(true);
        follow.teacher.SetActive(false);
        Invoke("activeTruePlayer", 3f);
    }
    void activeTruePlayer()
    {
        follow.teacher2.SetActive(false);
        follow.teacher.SetActive(true);
    }
   

}
