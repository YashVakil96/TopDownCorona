﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
 #region Variables

public float MoveSpeed=5f;
public Rigidbody2D rb;
public Camera cam;

Vector2 Movement;
Vector2 MousePos;

 #endregion

 #region System Methods
 private void Update() {
     Movement.x = Input.GetAxisRaw("Horizontal");
     Movement.y = Input.GetAxisRaw("Vertical");

    MousePos = cam.ScreenToWorldPoint(Input.mousePosition);

 }//update

 private void FixedUpdate() {
      rb.MovePosition(rb.position+Movement*MoveSpeed*Time.fixedDeltaTime);
      Vector2 lookDir= MousePos - rb.position;
      float angle=Mathf.Atan2(lookDir.y,lookDir.x)*Mathf.Rad2Deg-90f;
      rb.rotation = angle; 
 }//fixed update
 #endregion

 #region User Define Methods
 #endregion

}//class