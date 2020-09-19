using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Security.Cryptography;
using UnityEngine;

public class ball_1 : MonoBehaviour
{
    [SerializeField]
    private float startSpeed;

    [SerializeField]
    private Rigidbody2D objectRigidobody2d;

    public float LimitTime = 0;
    Vector2 vector2;
    float speed;

    static int cnt = 0;

    // Use this for initialization
    IEnumerator Start()
    {
        yield return new WaitForSeconds(1.0f);
        setvector();
        objectRigidobody2d.AddForce(getvector() * startSpeed);
        cnt++;
    }

    // Update is called once per frame
    void Update()
    {
        //카메라 밖에 안나가기
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);

        if (pos.x < 0f) pos.x = 0.3f;
        if (pos.x > 1f) pos.x = 1f;
        if (pos.y < 0f) pos.y = 0f;
        if (pos.y > 1f) pos.y = 1f;

        transform.position = Camera.main.ViewportToWorldPoint(pos);
    }
    void FixedUpdate()
    {
        // 속도 조절
        if (stopwatch() == 2)
        {
            Vector3 vector = Quaternion.AngleAxis(1, Vector3.forward) * Vector3.right;
            speed = 0.1f;
            objectRigidobody2d.AddForce(vector * speed);
        }
        else if (stopwatch() % 4 == 0.0)
        {
            Vector3 dir = transform.forward; // 전방 값 얻어오기
            dir.Normalize();
            speed = 0.2f;
            objectRigidobody2d.AddForce(dir * speed);
        }
        else if (stopwatch() % 10 == 0.0 && stopwatch() != 0.0)
        {
            Vector3 dir = transform.forward; // 전방 값 얻어오기
            dir.Normalize();
            speed = 0.35f;
            objectRigidobody2d.AddForce(dir * speed);
        }
    }

    public float stopwatch()
    {
        LimitTime += Time.deltaTime;
        return Mathf.Round(LimitTime);
    }

    void setvector()
    {
        Vector2 play_pos = GameObject.FindWithTag("Player").transform.position;
        Vector2 ball_pos = this.objectRigidobody2d.transform.position;

        vector2 = new Vector2(play_pos.x - ball_pos.x, play_pos.y - ball_pos.y);
        vector2 = vector2.normalized;
    }
    Vector2 getvector()
    {
        return vector2;
    }
    IEnumerator delayTime()
    {
        yield return new WaitForSeconds(1);
    }
}