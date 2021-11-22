using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public AudioClip sound;
    
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource> ();
        audioSource.enabled = false;
    }

    void OnMouseDown()
    {
        audioSource.enabled = true;
        if (!audioSource.isPlaying) {
            audioSource.clip = sound;
            audioSource.Play ();
        }
    }
}
