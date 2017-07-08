using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipWeapon : MonoBehaviour {

	#region Attributes

    public GameObject bulletPrefab;

    public float bulletSpawnDistance = .5f;

    #endregion

    #region Monobehaviour API

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) 
            || Input.GetKeyDown(KeyCode.LeftControl)
            || Input.GetMouseButtonDown(0))
        {
            FireBullet(transform.up
                        * bulletSpawnDistance
                        + transform.position,
                        transform.rotation);
        }
    }

    private void FireBullet(Vector3 position, Quaternion rotation)
    {
        Instantiate(bulletPrefab, position, rotation);
    }

    #endregion
}
