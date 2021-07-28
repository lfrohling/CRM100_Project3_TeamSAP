using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Shoot : MonoBehaviour
{

    public AudioSource source;
    public AudioClip shootSound;
    public GameObject projectilePrefab;
    public Transform barrelLocation;

    //private float fireRate = 0.0f;
    //private float nextFire = 0.0f;

    public float shootPower;
    //private bool triggerDown = false;

    // Start is called before the first frame update
    void Start()
    {
        if (barrelLocation == null)
        {
            barrelLocation = transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void LaunchProjectile()
    {
        Instantiate(projectilePrefab, barrelLocation.position, barrelLocation.rotation).GetComponent<Rigidbody>().AddForce(barrelLocation.forward * shootPower);
    }
}
