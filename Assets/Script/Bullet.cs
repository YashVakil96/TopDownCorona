using UnityEngine;
using TMPro;
public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        //create an explosion effect or hit effect
        //destroy the effect after its work is done
        //Destroy bullet on collision
        if(other.gameObject.name=="Top" || other.gameObject.name=="Bottom" || other.gameObject.name=="Left" || other.gameObject.name=="Right")
        {
            Destroy(gameObject);
        }
        else if(other.gameObject.tag=="Enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            EnemySpanner.EnemiesLeft--;
        }
    }
}//class