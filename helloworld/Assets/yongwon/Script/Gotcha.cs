using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Gotcha : MonoBehaviour
{
    int grade1 = 0;
    int grade2 = 0;
    int grade3 = 0;
    int grade4 = 0;
    int grade5 = 0;

    public TextMeshProUGUI result;

    int grade1Percent = 20;
    int grade2Percent = 50;
    int grade3Percent = 90;
    int grade4Percent = 98;
    int grade5Percent = 100;

    int janggiback = 1;


    public void RandomBox()
    {
        for(int i = 0; i < 30; i++)
        {
            int percent = Random.Range(0, 100);
                if(janggiback == 30)
                {
                grade5 += Random.Range(1,6);
                janggiback = 0;
                }
                else if (percent < grade1Percent)
                {
                    grade1 += Random.Range(20, 31);
                    janggiback++;
                }
                else if (percent < grade2Percent)
                {
                    grade2 += Random.Range(15, 26);
                    janggiback++;
                }
                else if (percent < grade3Percent)
                {
                    grade3 += Random.Range(10, 21);
                    janggiback++;
                }
                else if (percent < grade4Percent)
                {
                    grade4 += Random.Range(5, 11);
                    janggiback++;
                }
                else if(percent < grade5Percent)
                {
                    grade5 += Random.Range(1, 6);
                    janggiback = 0;
                }
            
        }

        result.text = "grade1:" + grade1 + "grade2:" + grade2  + "grade3:" + grade3 + "grade4" + grade4 + "grade5:" + grade5;
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
