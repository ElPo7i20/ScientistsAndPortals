using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDie : MonoBehaviour
{
    [SerializeField] PlayerInput input;
    [SerializeField] private GameObject enemy;
    private int killsCount;
    [SerializeField] Kills kills;
    private void Awake()
    {
        killsCount = 0;
    }
    public void DieFromPower(GameObject lightningStrike)
    {
        Destroy(lightningStrike);
        Destroy(enemy);
        killsCount++;
        kills.KillsScoreLevel(killsCount);
    }
}
