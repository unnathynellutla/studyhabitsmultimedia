using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController: MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2; 

    private SpriteRenderer spriteRenderer; 

    void Start ()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnMouseDown ()
    {
        
        spriteRenderer = GetComponent<SpriteRenderer>();
        Debug.Log(spriteRenderer.sprite.name);
       if (spriteRenderer.sprite == sprite1) 
        {
            Debug.Log(spriteRenderer.sprite.name);
            spriteRenderer.sprite = sprite2;
        }
        else
        {
            Debug.Log(spriteRenderer.sprite.name);
            spriteRenderer.sprite = sprite1; 
        } 
    } 

}
