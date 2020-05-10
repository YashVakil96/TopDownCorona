using UnityEngine;
using System.Collections;
using TMPro;
public class EnemySpanner : MonoBehaviour
{
    #region Variables
    public static int EnemiesLeft;

    public GameObject[] EnemyPrefb;
    public TMP_Text EnemiesLeftText;

    public int EnemySpawned;
    private Vector2 OldPos;
    private Vector2 CurrentPos;
    private Wave wave;
    private bool Invoked;

    #endregion 

    #region System Methods
    private void Start() {
        wave = FindObjectOfType<Wave>();
    }
    private void Update() 
    {
        if(Wave.IsWaveRunning && EnemySpawned!=Wave.EnemyToSpawn)
        {
            SpawnEnemy();
            if(EnemySpawned >= Wave.EnemyToSpawn)
            {
                Wave.IsWaveRunning=false;
                EnemySpawned=0;
            }
        }//If
        else
        {
             if(EnemiesLeft==0)
                {
                    if(!Invoked)
                    {
                        Invoke("NextWave",1);
                        Invoked=true;
                    }
                }
                Debug.Log("Here");
        }//else
        EnemiesLeftText.text=EnemiesLeft.ToString();
    }
    #endregion

    #region User Define Methods
    void SpawnEnemy()
    {
        if(OldPos==CurrentPos)
        {
            EnemySpawnPosition();
            transform.position=CurrentPos;
        }
        else
        {
            EnemySpawnPosition();
            transform.position=CurrentPos;

        }
        int EnemySelector = Random.Range(0,2);
        Instantiate(EnemyPrefb[EnemySelector], transform.position,Quaternion.identity);
        OldPos=transform.position;
        EnemySpawned++;
        EnemiesLeft++;  
    }//Spawn Enemy

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
        CurrentPos=new Vector2(x,y);
    }//EnemySpawnPosition
    void NextWave()
    {
        wave.StartNextWave();
        Invoked=false;
    }
    #endregion 
}//Class