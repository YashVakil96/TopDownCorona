using UnityEngine;

public class EnemySpanner : MonoBehaviour
{
    #region Variables
    public GameObject EnemyPrefb;
    #endregion 

    #region System Methods
    private void Update() {
         if(Input.GetKeyDown(KeyCode.Space))
         {
             SpawnEnemy();
         }
    }
    #endregion

    #region User Define Methods
    void SpawnEnemy()
    {
        EnemySpawnPosition();
        Instantiate(EnemyPrefb, transform.position,Quaternion.identity);
    }

     void EnemySpawnPosition()
    {
        float x,y;
        x= Random.Range(-10,10);
        if(Random.Range(0,2)==0)
        {
            y=7;
        }
        else
        {
            y=-7;
        }
        transform.position=new Vector2(x,y);
    }
    #endregion 
}//Class