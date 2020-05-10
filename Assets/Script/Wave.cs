using UnityEngine;
using TMPro;
public class Wave : MonoBehaviour
{
    #region Variables

    public static bool IsWaveRunning;
    public static int EnemyToSpawn;
    public TMP_Text WaveText;

    public int NoOfEnemies=5;
    private int WaveNO;

    #endregion

    #region System Methods
    private void Start() 
    {
        WaveNO = 1;
        IsWaveRunning=true;
        EnemyToSpawn = NoOfEnemies;
        WaveText.text= WaveNO.ToString();
    }//start

    private void Update() 
    {
    }//Update

    #endregion

    #region User Define Methods
    public void StartNextWave()
    {
        IsWaveRunning=true;
        WaveNO++;
        
        EnemyToSpawn = NoOfEnemies;
        WaveText.text= (WaveNO).ToString();
    }
    #endregion

}//class