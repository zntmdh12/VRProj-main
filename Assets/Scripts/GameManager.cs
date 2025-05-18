using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // static 어디서든 접근가능
    public static int Score;


    public TMP_Text txtScore;



    private void Update()
    {
        txtScore.text = Score.ToString();
    }

}
