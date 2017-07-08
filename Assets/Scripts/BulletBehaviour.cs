using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Copyright (C) Xenfinity LLC - All Rights Reserved
 * Unauthorized copying of this file, via any medium is strictly prohibited
 * Proprietary and confidential
 * Written by Bilal Itani <bilalitani1@gmail.com>, June 2017
 */

public class BulletBehaviour : MonoBehaviour {
	
    #region Attributes

    public float unitsPerSecond = 1;

    public float lifetime = 4;

    #endregion

    #region Monobehaviour API

    private void Start () 
	{
        Invoke("Destroy", lifetime);
	}

    private void Update () 
	{
        var forwardDir = transform.InverseTransformDirection(transform.up);
        transform.Translate(forwardDir * unitsPerSecond * Time.deltaTime);
	}

    #endregion

    private void Destroy()
    {
        Destroy(gameObject);
    }
}
