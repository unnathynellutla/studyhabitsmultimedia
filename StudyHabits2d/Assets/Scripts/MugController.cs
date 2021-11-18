using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MugController : MonoBehaviour
{
    bool clicked;
    void Update(){
        Transform ThisTransform = GetComponent<Transform>();
        if(clicked == true && ThisTransform.GetChild(1).gameObject.transform.localScale[1] < 1f){
            ThisTransform.GetChild(1).gameObject.transform.localScale += new Vector3(0f,0.001f,0f);
        }
        
    }
    void OnMouseDown(){
         Debug.Log("Mouse is over GameObject.");
         clicked = true;
        
    }
}
