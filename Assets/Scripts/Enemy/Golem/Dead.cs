using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    [SerializeField] private GameObject deadObject;
    [SerializeField] private GameObject golem;
    private int killsCount;
    [SerializeField] Kills kills;
    private void Awake()
    {
        killsCount = 0;
    }
    private void deadSpawn()
    {
        deadObject.SetActive(true);
        Destroy(golem);
        killsCount++;
        kills.KillsScoreLevel(killsCount);
    }
}
