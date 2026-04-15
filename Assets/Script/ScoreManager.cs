using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI nowScoreUI;
    public int nowScore;

    public TextMeshProUGUI BestScoreUI;
    public int BestScore;

    private void Start()
    {
        BestScore = PlayerPrefs.GetInt("BestScore");
        BestScoreUI.text = "BestScore:" + BestScore;
    }


}
