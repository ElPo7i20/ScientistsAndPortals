using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    private int pointsCount;
    private Text pointsScore;
    [SerializeField] EndScore[] endScore;

    private void Awake()
    {
        pointsScore = GetComponent<Text>();
        pointsCount = 0;
        pointsScore.text = "Points: " + pointsCount.ToString();
    }
    public void PointsScoreLevel(int point)
    {
        pointsCount += point;
        pointsScore.text = "Points: " + pointsCount.ToString();
        foreach (EndScore scoreP in endScore)
        {
            scoreP.PointsScoreEnd(pointsCount);
        }
    }
}
