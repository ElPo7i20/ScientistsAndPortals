using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InMainMenu : MonoBehaviour
{
    private void PressInMenu()
    {
        SceneManager.LoadScene(0);
    }
}
