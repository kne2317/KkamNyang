using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class runMap : MonoBehaviour
{

    public GameObject HY;
    public GameObject NE;
    public GameObject JH_pro;
    public GameObject CH;

    public Slider map;
    public GameObject startLine;
    public GameObject finishLine;

    void Start()
    {
        map.minValue= this.startLine.transform.position.x;
        map.maxValue = this.finishLine.transform.position.x;
    }
    
    void Update()
    {
       
    }
}
