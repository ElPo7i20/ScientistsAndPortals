using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kills : MonoBehaviour
{
    private Text killsScore;
    private int killsCount;
    [SerializeField] EndScore[] endScore;

    private void Awake()
    {
        killsScore = GetComponent<Text>();
        killsCount = 0;
        killsScore.text = "Kills: " + killsCount.ToString();
    }
    public void KillsScoreLevel(int kill)
    {
        killsCount += kill;
        killsScore.text = "Kills: " + killsCount.ToString();

        foreach (EndScore scoreK in endScore)
        {
            scoreK.KillsScoreEnd(killsCount);
        }
    }
}
