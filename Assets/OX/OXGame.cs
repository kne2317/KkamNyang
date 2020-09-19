using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class OXGame : MonoBehaviour
{
    public GameObject QuizT;
    public GameObject goodT;
    public GameObject badT;
    public GameObject numText;
    public GameObject ScoreText;

    public GameObject XPanel;
    public GameObject OPanel;
    public GameObject WrongText;
    public GameObject CorrectText;

    public static int scoreOX;
    public static int countGood;
    public static int countBad;
    int r;
    public static int numQ;

    public AudioClip O;
    public AudioClip X;
    AudioSource aud;

    void Start()
    {
        countGood = 0;
        countBad = 0;
        numQ = 1;
        scoreOX = 0;

         r = UnityEngine.Random.Range(0, QuizManager.Quiz.Count);
        QuizUp(r);
        Debug.Log(QuizManager.Answer[r]);

        this.aud = GetComponent<AudioSource>();

    }
    void Update()
    {
        goodT.GetComponent<Text>().text = "정답 "+countGood.ToString() + "문제";
        badT.GetComponent<Text>().text = "오답 " + countBad.ToString() + "문제";
        ScoreText.GetComponent<Text>().text = scoreOX+" 점";
        numText.GetComponent<Text>().text = "Q"+numQ.ToString() ;

    }

    void QuizUp(int r)
    {
        QuizT.GetComponent<Text>().text= QuizManager.Quiz[r];
    }

    public void ClickO()
    {

        int ch = Int32.Parse(QuizManager.Answer[r]);

        if (ch==0)
        {
            countGood++;
            Debug.Log("정답");
            scoreOX += 100;
            aud.clip = O;
            aud.Play();
            StartCoroutine(ShowO());
        }
        else
        {
            Debug.Log("땡");
            countBad++;
            scoreOX -= 50;
            aud.clip = X;
            aud.Play();
            StartCoroutine(ShowX());
        }
        nextQuiz();
    }
    public void ClickX()
    {

        int ch = Int32.Parse(QuizManager.Answer[r]);

        if (ch==1)
        {
            countGood++;
            Debug.Log("정답");
            scoreOX += 100;
            aud.clip = O;
            aud.Play();
            StartCoroutine(ShowO());
        }
        else
        {
            Debug.Log("땡");
            countBad++;
            scoreOX -= 50;
            aud.clip = X;
            aud.Play();
            StartCoroutine(ShowX());

        }
        nextQuiz();
    }
    void nextQuiz()
    {
        QuizManager.Quiz.RemoveAt(r);
        QuizManager.Answer.RemoveAt(r);
        r = UnityEngine.Random.Range(0, QuizManager.Quiz.Count);
        numQ++;
        QuizUp(r);
    }
    IEnumerator ShowX()
    {
        XPanel.SetActive(true);
        int count = 0;
        while (count < 2)
        {
            WrongText.SetActive(true);
            yield return new WaitForSeconds(0.5f);

            WrongText.SetActive(false);

            yield return new WaitForSeconds(0.5f);
            count++;
        }
        XPanel.SetActive(false);
    }
    IEnumerator ShowO()
    {
        OPanel.SetActive(true);
        int count = 0;
        while (count < 1)
        {
            WrongText.SetActive(true);
            yield return new WaitForSeconds(0.5f);

            WrongText.SetActive(false);

            yield return new WaitForSeconds(0.5f);
            count++;
        }
        OPanel.SetActive(false);
    }
}
