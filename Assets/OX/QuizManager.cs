using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public TextAsset QuizData;
    int lineSize, rowSize;

    public static List<string> Quiz = new List<string>();
    public static List<string> Answer = new List<string>();
    void Awake()
    {
        string currentText = QuizData.text.Substring(0, QuizData.text.Length - 1);
        string[] line = currentText.Split('\n');
        lineSize = line.Length;
        rowSize = line[0].Split('\t').Length;

            for(int i=0; i < lineSize; i++)
            {

                string []row = line[i].Split('\t');
                for (int j = 0; j < rowSize; j++)
                {

                    Quiz.Add(row[j]);
                    j++;
                    Answer.Add(row[j]);

                }
            }

    }

}
