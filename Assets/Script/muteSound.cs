using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muteSound : MonoBehaviour
{
    private AudioSource audioSource;
    private bool isMuted = false;

    void Start()
    {
        audioSource = GameObject.Find("backgroundMusic").GetComponent<AudioSource>();
    }

    public void ToggleMute()
    {
        isMuted = !isMuted;
        audioSource.mute = isMuted;
    }
}
