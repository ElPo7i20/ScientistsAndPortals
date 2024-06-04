using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundsInMainMenu : MonoBehaviour
{
    [SerializeField] SettingVolumeLevel soundLev;
    private Slider soundSlider;
    public float volAud;
    private void Awake()
    {
        soundSlider = GetComponent<Slider>();
        volAud = 1f;
        soundSlider.value = volAud;
    }
    public void SetVolume(float volume)
    {
        volAud = volume;
        soundLev.volumeMixer = volAud;
    }
}
