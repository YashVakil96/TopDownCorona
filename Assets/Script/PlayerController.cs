using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
 #region Variables
public float speed;

private Rigidbody2D rb;
 #endregion

 #region System Methods

/// <summary>
/// Start is called on the frame when a script is enabled just before
/// any of the Update methods is called the first time.
/// </summary>
void Start()
{
    rb=GetComponent<Rigidbody2D>();
}//start

 private void Update() {
     if(Input.GetKey(KeyCode.UpArrow))
     {
        //  transform.position = transform.up*speed*Time.deltaTime;
     }
 }//update
 #endregion

 #region User Define Methods
 #endregion

}//class