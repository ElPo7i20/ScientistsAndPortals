using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePanel : MonoBehaviour
{
    [SerializeField] private GameObject panelOne;
    [SerializeField] private GameObject panelTwo;

    private void PanelOffOn()
    {
        panelOne.SetActive(false);
        if(panelTwo != null)
        {
            panelTwo.SetActive(true);
        }
    }
}
