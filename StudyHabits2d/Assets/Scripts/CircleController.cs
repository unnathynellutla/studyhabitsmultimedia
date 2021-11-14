using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Transform ThisTransform = GetComponent<Transform>();
    //    anim = gameObject.GetComponent<Animator>();

        //Add 1 to x axis position
        ThisTransform.localScale = new Vector3(3.2f,0.5f,1f);
        
    }

    // Update is called once per frame
    void Update () 
    {
      //Transform component on this object
      Transform ThisTransform = GetComponent<Transform>();
      if(ThisTransform.localScale[1] < 1f){
          ThisTransform.localScale += new Vector3(0f,0.001f,0f);
      }
    }
}

/*void OnMouseDown(){
    anim.setTrigger("Active");
} */