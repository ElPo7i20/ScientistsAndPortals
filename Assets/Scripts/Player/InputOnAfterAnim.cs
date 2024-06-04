using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class InputOnAfterAnim : MonoBehaviour
{
    [SerializeField] private PlayerInput input;
    [SerializeField] private PlayerMovement move;

    private void InputEnableTrueAfterAnim()
    {
        input.enabled = true;
        move.enabled = true;
    }
}
