using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        //create an explosion effect or hit effect
        //destroy the effect after its work is done
        Debug.Log(other.gameObject.name);
        if(other.gameObject.name=="Top" || other.gameObject.name=="Bottom" || other.gameObject.name=="Left" || other.gameObject.name=="Right")
        {
            Destroy(gameObject);
        }
        
        
    }
}//class