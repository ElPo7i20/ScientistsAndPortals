using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{
    [SerializeField] private Text killsScore, pointsScore;
    public void KillsScoreEnd(int killsCount)
    {
        killsScore.text = killsScore.text + " " + killsCount.ToString();
    }
    public void PointsScoreEnd(int pointsCount)
    {
        pointsScore.text = pointsScore.text + " " + pointsCount.ToString();
    }
}
