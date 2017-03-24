using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTestScript : MonoBehaviour {

    public AudioSource playSound;
    public AudioClip playClip;
    private AudioSource source;

    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();
        source.clip = playClip;
    }
	

/*
    public void PlaySound()
    {
        playSound.Play();
        print("cube1");
    }

    public void PlaySoundOnDestroy()
    {
        print("cube2");
        playSound.Play();
        Destroy(gameObject);
            }
            */

    public void PlaySoundOnDestroy1()
    {
        print("cube3");
        AudioSource.PlayClipAtPoint(playClip, new Vector3(5, 1, 2));
        Destroy(gameObject);
    }
}
