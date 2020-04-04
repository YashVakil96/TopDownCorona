using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    #region Variable
    public Transform Player;
    public float MoveSpeed=.3f;

    private Vector2 Movement;
    private Rigidbody2D rb;
    #endregion

    #region System Methods
    private void Start() 
    {
        rb=GetComponent<Rigidbody2D>();
    }//Start

    private void FixedUpdate() {
        Vector2 Direction = Player.position - transform.position;
        float angle = Mathf.Atan2(Direction.y,Direction.x)*Mathf.Rad2Deg-90f;
        rb.rotation=angle;
        Movement=Direction;

        rb.MovePosition(rb.position+Movement*MoveSpeed*Time.fixedDeltaTime);
    }//FixedUpdate
    #endregion

    #region User Define Methods
    #endregion
}//class