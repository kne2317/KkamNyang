using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip bgm;
    public static AudioSource aud;
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
        aud = GetComponent<AudioSource>();
        aud.clip = bgm;
        aud.Play();
        aud.loop = true;
    }

}
