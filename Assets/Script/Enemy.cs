using UnityEngine;

public class Enemy : MonoBehaviour
{
    #region Variable
    public float MoveSpeed=.3f;

    private  Transform Player;
    private Vector2 Movement;
    private Rigidbody2D rb;
    private float Size;
    #endregion

    #region System Methods
    private void Start() 
    {
        switch(Random.Range(1,4))
        {
            case 1:
                Size=0.1f;
            break;

            case 2:
                Size=0.2f;
            break;
            case 3:
                Size=0.3f;
            break;
        }

        transform.localScale=new Vector3(Size,Size);

        rb=GetComponent<Rigidbody2D>();
        Physics2D.IgnoreLayerCollision(8,9);
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }//Start
  
    private void FixedUpdate() 
    {
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