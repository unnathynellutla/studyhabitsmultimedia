using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MugController : MonoBehaviour
{
    public AudioClip Coffee;
    private AudioSource audioSource;
    bool clicked;
    void Start () {
        audioSource = gameObject.GetComponent<AudioSource> ();
         audioSource.enabled = false;
    }
    void Update(){
        Transform ThisTransform = GetComponent<Transform>();
        if(clicked == true && ThisTransform.GetChild(1).gameObject.transform.localScale[1] < 1f){
            ThisTransform.GetChild(1).gameObject.transform.localScale += new Vector3(0f,0.001f,0f);
        }
        
    }
    void OnMouseDown(){
         Debug.Log("Mouse is over GameObject.");
         audioSource.enabled = true;
         if (!audioSource.isPlaying) {
             audioSource.clip = Coffee;
             audioSource.Play ();
         }
         clicked = true;
        
    }
}
