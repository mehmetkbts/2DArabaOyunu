using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text skor_tx;
    public static int skor;

    float zamanSayaci = 0f;

    void Start()
    {
        skor = 0;
    }

    void Update()
    {
        zamanSayaci += Time.deltaTime;
        if (zamanSayaci >= 1f)
        {
            skor += 1;
            zamanSayaci = 0f;
            skor_tx.text = skor.ToString();
        }
    }
}


