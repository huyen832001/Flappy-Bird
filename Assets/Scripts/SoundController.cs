using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    //design pattern(hinh mau code) :singleton
    public static SoundController instance;
    private void Awake()
    {
        instance = this;
    }
    //clipname truyen cai can choi vao
    //volumeMultiplier
    public void PlayThisSound(string clipName, float volumeMultiplier)
    {
        AudioSource audioSource = this.gameObject.AddComponent<AudioSource>();//AudioClip= none
        audioSource.volume *= volumeMultiplier;
        // PlayOneShot choi xen giua cac ban nhac
        //AudioClip note cac cai la audioclip
        audioSource.PlayOneShot((AudioClip)Resources.Load("Sounds/" + clipName, typeof(AudioClip)));
    }
}

