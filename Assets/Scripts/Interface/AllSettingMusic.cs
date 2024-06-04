using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AllSettingMusic : MonoBehaviour
{
    public float volMus;
    [SerializeField] Slider soundSlider;
    private AudioSource audSrc;
    private void Awake()
    {
        soundSlider.value = volMus;
        audSrc = GetComponent<AudioSource>();
    }
    private void Update()
    {
        audSrc.volume = volMus;
    }
    public void SetVolMus(float volume)
    {
        volMus = volume;
    }
}
