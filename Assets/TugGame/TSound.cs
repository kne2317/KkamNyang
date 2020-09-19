using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TSound : MonoBehaviour
{
    public AudioClip Tug;
    AudioSource a;
    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<AudioSource>();
        a.clip = Tug;
        a.Play();
        a.loop = true;
    }
}
