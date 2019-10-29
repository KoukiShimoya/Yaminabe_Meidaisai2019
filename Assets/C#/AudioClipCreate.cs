using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClipCreate : SingletonMonoBehaviour<AudioClipCreate>
{
    [SerializeField] private AudioClip answer;
    [SerializeField] private AudioClip wrong;
    [SerializeField] private AudioSource audioSource;
    
    public void SoundOn(bool isAnswer)
    {
        if (isAnswer)
        {
            audioSource.PlayOneShot(answer);
        }
        else
        {
            audioSource.PlayOneShot(wrong);
        }
    }
}
