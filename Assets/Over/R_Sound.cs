using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_Sound : MonoBehaviour
{
    public AudioClip rank;
    AudioSource a;
    // Start is called before the first frame update
    void Start()
    {
        a= GetComponent<AudioSource>();
        a.clip = rank;
        a.Play();
    }
}
