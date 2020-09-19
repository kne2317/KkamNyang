using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class ScoreGenerator : MonoBehaviour
{
    public GameObject javaPre;
    public GameObject adobePre;
    public GameObject andPre;
    public GameObject pythonPre;

    public GameObject errorPre;
    public GameObject err404Pre;

    List<GameObject> item = new List<GameObject>();


    void Start()
    {
       randomGenerator(130, 0f, 205f,-4.5f,2.8f);
        //randomG(0f, 160f, -4f, 3f);

        GameDirector.Runpoint = 0;
    }
    void randomG(float x1, float x2, float y1,float y2)
    {

        int rand = 0;
        GameObject s;
        
        for(float i=x1; i<=x2; i += 5)
        {
            for(float j=y1; j<=y2; j += 3)
            {
                rand=Random.Range(1, 7);

                if (rand == 1)
                {
                    s = Instantiate(javaPre) as GameObject;
                }
                else if (rand == 2)
                {
                    s = Instantiate(pythonPre) as GameObject;
                }
                else if (rand == 3)
                {
                    s = Instantiate(andPre) as GameObject;
                }
                else if (rand == 4)
                {
                    s = Instantiate(adobePre) as GameObject;
                }
                else if (rand == 5)
                {
                    s = Instantiate(errorPre) as GameObject;
                }
                else
                {
                    s = Instantiate(err404Pre) as GameObject;
                }
                s.transform.position = new Vector3(i,j, 0);
                item.Add(s);
            }
        }
        for(int i=0; i < item.Count; i++)
        {
            item[i].SetActive(true);
        }

    }
    void randomGenerator(int j, float x1, float x2,float y1, float y2)
    {
        GameObject s;

        for (int i = 0; i <= j; i++)
        {

            float randomX = Random.Range(x1, x2);
            float randomY = Random.Range(y1, y2);

            

            int rand = Random.Range(1, 7);

            if (rand == 1)
            {
                s = Instantiate(javaPre) as GameObject;
            }
            else if (rand == 2)
            {
                s = Instantiate(pythonPre) as GameObject;
            }
            else if (rand == 3)
            {
                s = Instantiate(andPre) as GameObject;
            }
            else if (rand == 4)
            {
                s = Instantiate(adobePre) as GameObject;
            }
            else if (rand == 5)
            {
                s = Instantiate(errorPre) as GameObject;
            }
            else
            {
                s = Instantiate(err404Pre) as GameObject;
            }
            s.transform.position = new Vector3(randomX, randomY, 0);
            
            s.SetActive(true);
            
        }
    }

}
