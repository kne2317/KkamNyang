using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public int Speed = 10;

    public AudioClip getPointS;
    public AudioClip losePointS;
    AudioSource aud;


    GameObject director;

    Vector3 textpos;

    [HideInInspector]
    public bool isFacingRight = true;


    public Slider map;


    void Start()
    {

        this.director = GameObject.Find("GameDirector");

        this.aud = GetComponent<AudioSource>();

    }

    void Update()
    {
        
        if (map.value >= map.minValue)
        {
            map.value = player.transform.position.x;
        }
        /*
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Speed* Time.deltaTime);
        }
        */
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down* Speed * Time.deltaTime);
        }


        Vector3 playerPos = this.player.transform.position;
        if (playerPos.y <= -3.5f)
        {
            transform.position= new Vector3(playerPos.x,-3.5f,0);
        }

        if (playerPos.y >= 1.8f)
        {
            transform.position = new Vector3(playerPos.x, 1.8f, 0);
        }

        if (playerPos.x <= -9f)
        {
            transform.position = new Vector3(-9f, playerPos.y, 0);
        }


    }
        void OnTriggerEnter2D(Collider2D other)
    {


        textpos = other.gameObject.transform.position;

        if (other.gameObject.tag == "plusS")
        {
            this.director.GetComponent<GameDirector>().PlusScore();
            aud.clip = getPointS;
            aud.Play();

        }
        else
        {
            this.director.GetComponent<GameDirector>().MinusScore();
            aud.clip = losePointS;
            aud.Play();

        }
        Destroy(other.gameObject);

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("End"))
        {
            Debug.Log("종료");
            SceneManager.LoadScene("RunOver");
        }
    }

}
