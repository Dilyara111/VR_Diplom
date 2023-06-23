using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public TMP_Text scoreText;
    private int sec = 0;

    private void Start()
    {
        StartCoroutine(ScoreTime());
    }


    IEnumerator ScoreTime()
    {
        while (true)
        {
            sec++;
            scoreText.text = sec.ToString();
            yield return new WaitForSeconds(1);
        }
        

    }

}
