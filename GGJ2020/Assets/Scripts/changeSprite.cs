using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSprite : MonoBehaviour

{
    public Sprite []sprite;
    public GameObject gameBoy;
    int spriteNumber =0;
    SpriteRenderer spriteRenderer;
   
    // Start is called before the first frame update

    // Update is called once per frame
    void Start(){
        spriteRenderer.sprite= sprite[spriteNumber];
    }
    void Update()

    {
        SpriteRenderer spriteRenderer = gameBoy.GetComponent<SpriteRenderer>();
        
        spriteRenderer.sprite = sprite[spriteNumber];

    }

    public void SpriteChanger()
    {
        if(spriteNumber< sprite.Length){
        spriteNumber++;
        }
       
        if(spriteNumber == sprite.Length){
            spriteNumber = 0;

        }
        

         
    }
}
