using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosive : MonoBehaviour
{
    public GameObject ExplosionEffect;

    void OnTriggerEnter2D ()
    {
        Instantiate(ExplosionEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
