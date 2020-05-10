using UnityEngine;
using System.Collections;
using TMPro;
public class Shooting : MonoBehaviour
{
    #region Variables
    public Transform GunPoint;
    public GameObject BulletPrefab;
    public TMP_Text BulletCountText;

    public float BulletForce = 20f;
    public int BulletCount=15;

    private bool CanShoot;
    #endregion

    #region System Methods
    private void Start() {
        CanShoot=true;
        BulletCountText.text=BulletCount.ToString();
    }


    private void Update() {
        if(Input.GetButtonDown("Fire1"))
        {
            if(CanShoot)
            {
                Shoot();
                BulletCount--;
                if(BulletCount==0)
                {
                    BulletCountText.text="Reloading";
                    StartCoroutine(Reload());
                }
                else
                {
                    BulletCountText.text=BulletCount.ToString();
                    StartCoroutine(StartDelay());
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(Reload());
        }

    }
    #endregion

    #region User Define Methods
    void Shoot()
    {
        GameObject bullet = Instantiate(BulletPrefab,GunPoint.position,GunPoint.rotation);
        Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();
        bulletRb.AddForce(GunPoint.up * BulletForce,ForceMode2D.Impulse) ;
    }
    IEnumerator StartDelay()
    {
        CanShoot=false;
        yield return new WaitForSeconds(.2f);
        CanShoot=true;
    }

    IEnumerator Reload()
    {
        CanShoot=false;
        yield return new WaitForSeconds(1f);
        CanShoot=true;
        BulletCountText.text="15";
        BulletCount=15;

    }
    #endregion
}//class