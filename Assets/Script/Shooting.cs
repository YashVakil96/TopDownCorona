using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    #region Variables
    public Transform GunPoint;
    public GameObject BulletPrefab;

    public float BulletForce = 20f;

    #endregion

    #region System Methods
    private void Update() {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    #endregion

    #region User Define Methods
    void Shoot()
    {
        GameObject bullet = Instantiate(BulletPrefab,GunPoint.position,GunPoint.rotation);
        Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();
        bulletRb.AddForce(GunPoint.up * BulletForce,ForceMode2D.Impulse);
    }
    #endregion
}//class