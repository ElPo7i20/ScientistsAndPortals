using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicInMainMenu : MonoBehaviour
{
    [SerializeField] AllSettingMusic musLev;
    [SerializeField] private Slider soundSlider;
    private AudioSource audSrc;
    public float volM;
    private void Awake()
    {
        volM = 1f;
        soundSlider.value = volM;
        audSrc = GetComponent<AudioSource>();
    }
    private void Update()
    {
        audSrc.volume = volM;
    }
    public void SetVolume(float volume)
    {
        volM = volume;
        musLev.volMus = volume;
    }
}
