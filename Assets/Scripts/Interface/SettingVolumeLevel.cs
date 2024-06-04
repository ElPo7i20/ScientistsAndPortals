using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingVolumeLevel : MonoBehaviour
{
    [SerializeField] SoundsInMainMenu soundsInMainMenu;
    public string volumePar = "MasterVolume";
    public AudioMixer mixer;
    public float volumeMixer;

    public void SetAllVolume(float volumeValue)
    {
        volumeMixer =  Mathf.Log10(volumeValue) * 30f;
        mixer.SetFloat(volumePar, volumeMixer);
        soundsInMainMenu.volAud = volumeMixer;
    }
    
    private void OnDisable()
    {
        PlayerPrefs.SetFloat(volumePar, volumeMixer);
    }
}
