﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public AudioMixer sfxMixer;
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }


    public void SetSfxVolume(float volume)
    {
        sfxMixer.SetFloat("volume", volume);
    }
}
